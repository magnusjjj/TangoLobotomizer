using HtmlAgilityPack;
using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace PetriNoitaLib
{


    public class EntityFile
    {
        // This is a dictionary that looks something like this in use: dict["componentName"]["attributeName"].Type;
        public static Dictionary<string, Dictionary<string, (string Type, int Size)>> ComponentAttributeDictionary = new Dictionary<string, Dictionary<string, (string Type, int Size)>>(); // Todo: Refactor to store this somewhere more sane, and thread safe

        public void Read(string filename)
        {
            MemoryStream stream = LZFile.ReadFile(filename);

            UInt32 hash_exists = BEHelper.ReadBeUInt32(stream);
            if (hash_exists != 0x00000002 && hash_exists != 0x00020020)
            {
                throw new Exception("Wrong hash exists value! " + hash_exists);
            }

            UInt32 hash_size = BEHelper.ReadBeUInt32(stream);

            if (hash_size != 0x20)
            {
                throw new Exception("Wrong hash size!");
            }

            byte[] hash = new byte[hash_size];
            stream.Read(hash, 0, (int)hash_size);

            string schema_content = File.ReadAllText("C:\\Program Files (x86)\\Steam\\steamapps\\common\\Noita\\data\\schemas\\" + System.Text.Encoding.ASCII.GetString(hash) + ".xml");

            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(schema_content);

            foreach (var node in doc.DocumentNode.ChildNodes[0].ChildNodes)
            {
                if (node.Name == "#text")
                    continue;
                if (node.Name != "component")
                    throw new Exception("Unknown document node type: " + node.Name);
                if (node.Attributes.Count != 1)
                    throw new Exception("Component with unknown parameters: " + string.Join(" ", node.Attributes));

                ComponentAttributeDictionary[node.Attributes["component_name"].Value] = new Dictionary<string, (string Type, int Size)>();

                foreach (var attributeNode in node.ChildNodes)
                {
                    if (attributeNode.Name == "#text")
                        continue;
                    if (attributeNode.Name != "var")
                        throw new Exception("Unknown component attribute type: " + attributeNode.Name);
                    if (attributeNode.Attributes.Count != 3)
                        throw new Exception("Component attribute with unknown parameters: " + string.Join(" ", node.Attributes));

                    ComponentAttributeDictionary[node.Attributes["component_name"].Value][attributeNode.Attributes["name"].Value] = (attributeNode.Attributes["type"].Value, int.Parse(attributeNode.Attributes["size"].Value));

                    //                    Console.WriteLine(attributeNode.ToString());
                }
                //                Console.WriteLine(node);
            }

            UInt32 num_entities = BEHelper.ReadBeUInt32(stream);
            for (int i = 0; i < num_entities; i++)
            {
                Entity e = new Entity();
                e.Read(stream);
            }
        }

        public class Component
        {
            NoitaString Name;
            List<string> Tags;
            Dictionary<string, object> Fields = [];
            bool Enabled;
            bool PossiblyNotDeleted;

            public void Read(Stream stream)
            {
                Name = new NoitaString();
                Name.Load(stream);
                PossiblyNotDeleted = stream.ReadByte() > 0;
                Enabled = stream.ReadByte() > 0;
                NoitaString temp_tag = new NoitaString();
                temp_tag.Load(stream);
                Tags = temp_tag.value.Split(",").ToList();

                var br = new BinaryReader(stream);

                foreach (var field in ComponentAttributeDictionary[Name.value])
                {
                    var FieldName = field.Key;
                    var TypeSize = field.Value;
                    Fields.Add(FieldName, DoType(stream, TypeSize.Type));
                }
            }
        }







        // Type name in regex to match, function that returns an object of that type, function that writes an object of that type
        public static List<(Regex tomatch, Func<Stream, MatchCollection, object> reader, Action<Stream> writer)> type_converters = [
            (new Regex("^float$"), (s, m) => BEHelper.ReadBeFloat(s), (s) => s.Write(Encoding.ASCII.GetBytes("hello"))),
            (new Regex("^double$"), (s, m) => BEHelper.ReadBeDouble(s), (s) => s.Write(Encoding.ASCII.GetBytes("hello"))),
            (new Regex("^int$"), (s, m) => BEHelper.ReadBeInt32(s), (s) => s.Write(Encoding.ASCII.GetBytes("hello"))),
            (new Regex("^int32$"), (s, m) => BEHelper.ReadBeInt32(s), (s) => s.Write(Encoding.ASCII.GetBytes("hello"))),
            (new Regex("^__int64$"), (s, m) => BEHelper.ReadBeInt64(s), (s) => s.Write(Encoding.ASCII.GetBytes("hello"))),
            (new Regex("^unsigned int$"), (s, m) => BEHelper.ReadBeUInt32(s), (s) => s.Write(Encoding.ASCII.GetBytes("hello"))),
            (new Regex("^uint32$"), (s, m) => BEHelper.ReadBeUInt32(s), (s) => s.Write(Encoding.ASCII.GetBytes("hello"))),
            (new Regex("^unsigned __int64$"), (s, m) => BEHelper.ReadBeUInt64(s), (s) => s.Write(Encoding.ASCII.GetBytes("hello"))),
            (new Regex("^unsigned short$"), (s, m) => BEHelper.ReadBeUInt16(s), (s) => s.Write(Encoding.ASCII.GetBytes("hello"))),
            (new Regex("^bool$"), (s, m) => {
                var b = s.ReadByte();
                if(b > 1) throw new Exception("Bool was over 1!");
                return (b > 0);
            }, (s) => s.Write(Encoding.ASCII.GetBytes("hello"))),
            (new Regex("^special texture$"), (s, m) => {
                FieldSpecialTexture fst = new FieldSpecialTexture();
                if(s.ReadByte() == 0) return new FieldSpecialTexture(){ };
                fst.IsSpecial = true;
                fst.Height = BEHelper.ReadBeInt32(s); // TODO: Can this really be negative?
                fst.Width = BEHelper.ReadBeInt32(s);
                fst.Data = new UInt32[fst.Height * fst.Width];
                for(int i = 0; i < fst.Height * fst.Width; i++) fst.Data[i] = BEHelper.ReadBeUInt32(s);
                return fst;
            }, (s) => s.Write(Encoding.ASCII.GetBytes("hello"))),
            (new Regex("^class ceng::math::CVector2<(.*)>$"), (s, m) => {
                string realtype = m[0].Groups[1].Value;
                return new FieldCVector2(){ a = DoType(s, realtype), b = DoType(s, realtype)};
            }, (s) => s.Write(Encoding.ASCII.GetBytes("hello"))),
            (new Regex("^struct LensValue<(.*)>$"), (s, m) => {
                string realtype = m[0].Groups[1].Value;
                return new FieldLens(){ Value = DoType(s, realtype), Default = DoType(s, realtype), Frame = BEHelper.ReadBeInt32(s) };
            }, (s) => s.Write(Encoding.ASCII.GetBytes("hello"))),
            (new Regex("^class std::vector<(.*)>$"), (s, m) => { // TODO: Check that inner types are supported. 4 bytes can't be everything? It also discards the content
                // class std::vector<class std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> >,class std::allocator<class std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> > > >
                string inner = m[0].Groups[1].Value;
                int count = 0;
                string true_type = "";
                for(int i = 0; i < inner.Length; i++){
                    var character = inner[i];
                    if(character == ',' && count == 0)
                    {
                        true_type = inner.Substring(0, i); 
                    } else if(character == '<'){
                        count++;
                    } else if(character == '>'){
                        count--;
                    }
                }

                FieldVector fieldVector = new FieldVector();
                uint length = BEHelper.ReadBeUInt32(s);
                for(int i = 0; i < length; i++)
                {
                    fieldVector.Values.Add(DoType(s, true_type));
                }

                return fieldVector;
            }, (s) => s.Write(Encoding.ASCII.GetBytes("hello"))),
            (new Regex("^(class std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> >$)|^(string$)"), (s, m) => {
                uint length = BEHelper.ReadBeUInt32(s);
                byte[] buffer = new byte[length];
                s.ReadExactly(buffer);
                return Encoding.ASCII.GetString(buffer);
            }, (s) => s.Write(Encoding.ASCII.GetBytes("hello"))),
            (new Regex("^UintArrayInline$|^struct UintArrayInline$"), (s, m) => {
                uint length = BEHelper.ReadBeUInt32(s);
                FieldUintArrayInline fieldUintArrayInline = new FieldUintArrayInline();
                fieldUintArrayInline.Data = new UInt32[length];
                for(int i = 0; i < length; i++) fieldUintArrayInline.Data[i] = BEHelper.ReadBeUInt32(s);
                return fieldUintArrayInline;
            }, (s) => s.Write(Encoding.ASCII.GetBytes("hello"))),
            (new Regex("^Enum$"), (s, m) => {
                uint length = BEHelper.ReadBeUInt32(s);
                byte[] buffer = new byte[length];
                s.ReadExactly(buffer);
                return Encoding.ASCII.GetString(buffer);
            }, (s) => s.Write(Encoding.ASCII.GetBytes("hello"))),
        ];

        public static object DoType(Stream s, string type)
        {
            foreach (var converter in type_converters)
            {
                MatchCollection m = converter.tomatch.Matches(type);
                if (m.Count > 0)
                {
                    return converter.reader(s, m);
                    //                            object test = converter.reader(stream);
                }
            }
            throw new Exception("Unknown converter type: " + type);
        }

        class FieldSpecialTexture
        {
            public bool IsSpecial { get; set; } // STOPPED AT LINE 156, due to recursive type reading.
            public Int32 Width { get; set; }
            public Int32 Height { get; set; }
            public UInt32[]? Data { get; set; }
        }

        class FieldUintArrayInline
        {
            public UInt32[]? Data { get; set; }
        }

        class FieldCVector2
        {
            public object a { get; set; }
            public object b { get; set; }
        }

        class FieldLens
        {
            public object Value { get; set; }
            public object Default { get; set; }
            public int Frame { get; set; }
        }

        class FieldVector
        {
            public List<object> Values = [];
        }

        public class Entity
        {
            string Name = "";
            bool Deleted;
            string Path = "";
            List<string> Tags = [];
            float X;
            float Y;
            float SizeX;
            float SizeY;
            float Rotation;
            List<Component> Components = [];

            public void Read(Stream stream)
            {
                NoitaString name_temp = new NoitaString();
                name_temp.Load(stream);
                Name = name_temp.value;
                Deleted = stream.ReadByte() > 0;
                NoitaString path_temp = new NoitaString();
                path_temp.Load(stream);
                Path = path_temp.value;
                NoitaString tag_temp = new NoitaString();
                tag_temp.Load(stream);
                Tags = tag_temp.value.Split(",").ToList();
                X = BEHelper.ReadBeFloat(stream);
                Y = BEHelper.ReadBeFloat(stream);
                SizeX = BEHelper.ReadBeFloat(stream);
                SizeY = BEHelper.ReadBeFloat(stream);
                Rotation = BEHelper.ReadBeFloat(stream);
                UInt32 num_components = BEHelper.ReadBeUInt32(stream);
                for (int i = 0; i < num_components; i++)
                {
                    Component c = new Component();
                    c.Read(stream);
                    Components.Add(c);
                }
            }
        }
    }
}
