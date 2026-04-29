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

namespace GeneratedNoitaClasses
{
    public class EntityFile
    {
        public byte[] EmptyFlag { get; set; } =  new byte[4]; // A very strange thing. In little endian, a file with 0x00020020 is empty. A file with 0x00000002 has content in it.
        // uint32 hash size here
        public string Hash { get; set; } = ""; // This is filled with a sort of checksum. That checksum is the filename (sans .xml and path) of an xml file with the file format specification in it.
        // uint32 entity number here
        public List<Entity> Entities { get; set; } = new List<Entity>();

        public void Read(NoitaStream stream)
        {
            // Read some of the stream headers
            stream.ReadAtLeast(EmptyFlag, EmptyFlag.Length);
            Hash = stream.ReadBeString();
            UInt32 num_entities = stream.ReadBeUInt32();
            if(Hash != "")
            { 
                for(int i = 0; i < num_entities; i++)
                {
                    Entity entity = new Entity();
                    entity.Read(stream);
                    Entities.Add(entity);
                }
            }
        }

        public static EntityFile Read(string path)
        {
            EntityFile ef = new EntityFile();
            ef.Read(LZFile.ReadFile(path));
            return ef;
        }

        public void Write(NoitaStream stream)
        {
            if (Entities.Count == 0)
            {
                stream.Write(new byte[] { 0, 2, 0, 32, 0, 0, 0, 0 });
                stream.Write(new byte[0x24]);
                return;
            } else
            {
                stream.Write(new byte[] { 0, 0, 0, 2});
            }

            stream.WriteBeString(Hash);
            stream.WriteBeUInt32((uint)Entities.Count);
            foreach(Entity entity in Entities)
            {
                entity.Write(stream);
            }
        }
    }

    public class Entity
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
        public List<NoitaComponentBase> Components { get; set; } = [];
        public List<Entity> Children { get; set; } = [];

        public void Read(NoitaStream s)
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
                string componenttypename = s.ReadBeString();
                NoitaComponentBase component = (NoitaComponentBase)GeneratedClassFinder.GetGeneratedClass(componenttypename);
                component.ComponentName = componenttypename;
                //t.make iNoitaType
                ((iNoitaType)component).Read(s);
                Components.Add(component);
            }

            UInt32 num_children = s.ReadBeUInt32();
            for (int i = 0; i < num_children; i++)
            {
                Entity child = new Entity();
                child.Read(s);
                Children.Add(child);
            }
        }

        public void Write(NoitaStream s)
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
            foreach(NoitaComponentBase component in Components)
            {
                s.WriteBeString(component.ComponentName);
                ((iNoitaType)component).Write(s);
            }

            s.WriteBeUInt32((uint)Children.Count);
            foreach (Entity child in Children)
            {
                child.Write(s);
            }
        }

        public class ComponentContainer
        {
            public string ComponentName { get; set; } = string.Empty;
            public required iNoitaType Component { get; set; }
        }
    }
}
