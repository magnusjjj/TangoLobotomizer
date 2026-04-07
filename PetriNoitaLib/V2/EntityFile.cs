using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;
using System.Windows.Markup;

namespace PetriNoitaLib.V2
{
    public class EntityFile
    {
        public byte[] EmptyFlag { get; set; } =  new byte[4]; // A very strange thing. In little endian, a file with 0x00020020 is empty. A file with 0x00000002 has content in it.
        // uint32 hash size here
        public string Hash { get; set; } = ""; // This is filled with a sort of checksum. That checksum is the filename (sans .xml and path) of an xml file with the file format specification in it.
        // uint32 entity number here
        List<Entity> Entities { get; set; } = new List<Entity>();
        private NoitaStream stream;

        public EntityFile(NoitaStream ns) {
            stream = ns;
        }

        public void Read()
        {
            // Read some of the stream headers
            stream.ReadAtLeast(EmptyFlag, EmptyFlag.Length);
            Hash = stream.ReadBeString();
            UInt32 num_entities = stream.ReadBeUInt32();
            // Read the schema matching the savefile. It's like a version number thing.
            SchemaFile schemaFile = new SchemaFile();
            schemaFile.Load(Hash);
            for(int i = 0; i < num_entities; i++)
            {
                Entity entity = new Entity(stream, schemaFile);
                entity.Read();
                Entities.Add(entity);
            }
        }

        public static EntityFile Read(string path)
        {
            EntityFile ef = new EntityFile(LZFile.ReadFile(path));
            ef.Read();
            return ef;
        }

        public void Write()
        {
            stream.WriteBytes(EmptyFlag);
            stream.WriteBeString(Hash);
            stream.WriteBeUInt32((uint)Entities.Count);
            foreach(Entity entity in Entities)
            {
                entity.Write();
            }
        }
    }

    class Entity
    {
        public string Name { get; set; } = "";
        public bool Deleted { get; set; } = false;
        public string Path { get; set; } = "";
        public string Tags { get; set; } = "";
        public float X { get; set; }
        public float Y { get; set; }
        public float ScaleX { get; set; }
        public float ScaleY { get; set; }
        public float Rotation { get; set; }
        public List<Component> Components { get; set; } = [];
        public List<Entity> Children { get; set; } = [];
    
        NoitaStream s;
        SchemaFile schema;

        public Entity(NoitaStream s, SchemaFile schema)
        {
            this.s = s;
            this.schema = schema;
        }

        public void Read()
        {
            Name = s.ReadBeString();
            Deleted = s.ReadBool();
            Path = s.ReadBeString();
            Tags = s.ReadBeString();
            X = s.ReadBeFloat();
            Y = s.ReadBeFloat();
            ScaleX = s.ReadBeFloat();
            ScaleY = s.ReadBeFloat();
            Rotation = s.ReadBeFloat();
            UInt32 num_components = s.ReadBeUInt32();
            for (int i = 0; i < num_components; i++)
            {
                Component component = new Component(s, schema);
                component.Read();
                Components.Add(component);
            }

            UInt32 num_children = s.ReadBeUInt32();
            for (int i = 0; i < num_children; i++)
            {
                Entity child = new Entity(s, schema);
                child.Read();
                Children.Add(child);
            }
        }

        public void Write()
        {
            s.WriteBeString(Name);
            s.WriteBool(Deleted);
            s.WriteBeString(Path);
            s.WriteBeString(Tags);
            s.WriteBeFloat(X);
            s.WriteBeFloat(Y);
            s.WriteBeFloat(ScaleX);
            s.WriteBeFloat(ScaleY);
            s.WriteBeFloat(Rotation);
            s.WriteBeUInt32((uint)Components.Count);
            foreach(Component component in Components)
            {
                component.Write();
            }

            s.WriteBeUInt32((uint)Children.Count);
            foreach (Entity child in Children)
            {
                child.Write();
            }
        }
    }

    class TypeReader
    {
        public static object? ReadType(NoitaStream s, SchemaFile schema, string typename)
        {
            switch (typename)
            {
                case "float": return s.ReadBeFloat();
	            case "double": return s.ReadBeDouble();
	            case "int": return s.ReadBeInt32();
	            case "int32": return s.ReadBeInt32();
                case "__int64": return s.ReadBeInt64();
                case "unsigned int": return s.ReadBeUInt32();
                case "uint32": return s.ReadBeUInt32();
	            case "unsigned __int64": return s.ReadBeInt64();
	            case "unsigned short": return s.ReadBeUInt16();
                case "bool": return s.ReadBool();
                case "struct SpriteStains *": return null; // Zero length, verified by ye ol snail
                default:
                break;
            }

            if(typename == "special texture")
            {
                return SpecialTexture.Read(schema, s);
            }

            if(typename == "class std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> >" || typename == "string")
            {
                return s.ReadBeString();
            }

            string vec2 = "class ceng::math::CVector2<";

            if (typename.StartsWith(vec2))
            {
                string real_type = typename[vec2.Length..^1];
                return Vec2.Read(real_type, schema, s);
            }


            if (typename.EndsWith("Enum"))
            {
                return s.ReadBytes(schema.TypeSizes[typename]).Reverse().ToArray();
            }


            string vectormatch = "class std::vector<";
            if (typename.StartsWith(vectormatch))
            {
                string true_type = "";
                int bracket_num = 0;
                for(int i = vectormatch.Length; i < typename.Length; i++)
                {
                    if (typename[i] == '<')
                        bracket_num++;

                    if (typename[i] == '>')
                        bracket_num--;

                    if (typename[i] == ',' && bracket_num == 0)
                    {
                        true_type = typename[vectormatch.Length..i];
                        return Vector.Read(true_type, schema, s);
                    }
                }
            }

            if (StaticObjectTypes.ObjectFormatLookup.ContainsKey(typename))
            {
                return ObjectType.Read(typename, schema, s);
            }
            

            throw new NotImplementedException(typename + " not implemented");

            return null;
        }

        class SpecialTexture
        {
            public uint Width { get; set; }
            public uint Height { get; set; }
            public uint[] Values { get; set; }



            public static SpecialTexture? Read(SchemaFile schema, NoitaStream s)
            {
                if (s.ReadBool()) // Flag to find if a special texture is up next or to ignore it
                {
                    SpecialTexture specialTexture = new SpecialTexture();
                    specialTexture.Width = s.ReadBeUInt32();
                    specialTexture.Height = s.ReadBeUInt32();
                    specialTexture.Values = new uint[specialTexture.Width * specialTexture.Height];
                    for(int i = 0; i <  specialTexture.Values.Length; i++)
                    {
                        specialTexture.Values[i] = s.ReadBeUInt32();
                    }
                    return specialTexture;
                }
                return null;
            }

            internal static void Write(SchemaFile schema, NoitaStream s, object? value)
            {
                throw new NotImplementedException();
            }
        }

        class Vector
        {
            public string Type { get; set; } = "";
            public List<object> Values { get; set; } = [];

            public static Vector Read(string typename, SchemaFile schema, NoitaStream s)
            {
                Vector v = new Vector();
                UInt32 len = s.ReadBeUInt32();
                for(int i = 0; i < len; i++)
                {
                    v.Values.Add(TypeReader.ReadType(s, schema, typename));
                }
                return v;
            }

            internal static void Write(string true_type, SchemaFile schema, NoitaStream s, object? value)
            {
                throw new NotImplementedException();
            }
        }

        class Vec2
        {
            public object X { get; set; }
            public object Y { get; set; }

            public static Vec2 Read(string Typename, SchemaFile schema, NoitaStream s)
            {
                return new Vec2() { X = TypeReader.ReadType(s, schema, Typename), Y = TypeReader.ReadType(s, schema, Typename) };
            }

            internal static void Write(string real_type, SchemaFile schema, NoitaStream s, object? value)
            {
                throw new NotImplementedException();
            }
        }

        class ObjectType
        {
            public List<(string name, string type, object value)> Values { get; set; } = [];

            public static ObjectType Read(string Typename, SchemaFile schema, NoitaStream s)
            {
                var ot = new ObjectType();
                foreach (var part in StaticObjectTypes.ObjectFormatLookup[Typename])
                {
                    ot.Values.Add((part[0], part[1], TypeReader.ReadType(s, schema, part[1])));
                }
                return ot;
            }

            internal static void Write(string typename, SchemaFile schema, NoitaStream s, object? value)
            {
                throw new NotImplementedException();
            }
        }

        public static void WriteType(NoitaStream s, SchemaFile schema, string typename, object? value)
        {
            switch (typename)
            {
                case "float": s.WriteBeFloat((float)value); break;
                case "double": s.WriteBeDouble((double)value); break;
                case "int": s.WriteBeInt32((int)value); break;
                case "int32": s.WriteBeInt32((int)value); break;
                case "__int64": s.WriteBeInt64((long)value); break;
                case "unsigned int": s.WriteBeUInt32((uint)value); break;
                case "uint32": s.WriteBeUInt32((uint)value); break;
                case "unsigned __int64": s.WriteBeInt64((long)value); break;
                case "unsigned short": s.WriteBeUInt16((ushort)value); break;
                case "bool": s.WriteBool((bool)value); break;
                case "struct SpriteStains *": return; // Zero length, verified by ye ol snail
                default:
                    break;
            }

            if (typename == "special texture")
            {
                SpecialTexture.Write(schema, s, value);
                return;
            }

            if (typename == "class std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> >" || typename == "string")
            {
                s.WriteBeString((string)value);
                return;
            }

            string vec2 = "class ceng::math::CVector2<";

            if (typename.StartsWith(vec2))
            {
                string real_type = typename[vec2.Length..^1];
                Vec2.Write(real_type, schema, s, value);
                return;
            }

            if (typename.EndsWith("Enum"))
            {
                s.WriteBytes((byte[])value);
            }


            string vectormatch = "class std::vector<";
            if (typename.StartsWith(vectormatch))
            {
                string true_type = "";
                int bracket_num = 0;
                for (int i = vectormatch.Length; i < typename.Length; i++)
                {
                    if (typename[i] == '<')
                        bracket_num++;

                    if (typename[i] == '>')
                        bracket_num--;

                    if (typename[i] == ',' && bracket_num == 0)
                    {
                        true_type = typename[vectormatch.Length..i];
                        Vector.Write(true_type, schema, s, value);
                        return;
                    }
                }
            }

            if (StaticObjectTypes.ObjectFormatLookup.ContainsKey(typename))
            {
                ObjectType.Write(typename, schema, s, value);
            }


            throw new NotImplementedException(typename + " not implemented");
        }
    }

    class Component
    {
        NoitaStream s;
        SchemaFile schema;

        public string Name { get; set; } = "";
        public bool Deleted { get; set; } = false;
        public bool Enabled { get; set; } = false;
        public string Tags { get; set; } = "";
        public List<Field> Fields { get; set; } = [];

        public Component(NoitaStream s, SchemaFile schema)
        {
            this.s = s;
            this.schema = schema;
        }

        public void Read()
        {
            Name = s.ReadBeString();
            Deleted = s.ReadBool();
            Enabled = s.ReadBool();
            Tags = s.ReadBeString();
            List<SchemaFile.ComponentVar> componentvars = schema.GetComponentVars(Name);
            foreach (var componentvar in componentvars)
            {
                Field f = new Field(s, schema, componentvar.Type, componentvar.Name);
                f.Read();
                Fields.Add(f);
            }
        }

        public void Write()
        {
            s.WriteBeString(Name);
            s.WriteBool(Deleted);
            s.WriteBool(Enabled);
            s.WriteBeString(Tags);
            foreach(var field in Fields)
            {
                field.Write();
            }
        }
    }

    class Field
    {
        public string TypeName { get; set; } = "";
        public string Name { get; set; } = "";
        object? Value = null;

        private NoitaStream s;
        private SchemaFile schema;

        public Field(NoitaStream s, SchemaFile schemaFile, string TypeName, string Name)
        {
            this.TypeName = TypeName;
            this.Name = Name;
            this.s = s;
            this.schema = schemaFile;
        }

        public void Read()
        {
            Value = TypeReader.ReadType(s, schema, TypeName);
        }

        public void Write()
        {
            TypeReader.WriteType(s, schema, TypeName, Value);
        }
    }
}
