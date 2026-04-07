using PetriNoitaLib.V2;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace EntityFileReaderGenerator
{
    internal class StaticObjectTypesGenerator
    {
        public static void Generate(string directory)
        {
            Directory.CreateDirectory(directory);
            foreach (var part in StaticObjectTypes.ObjectFormatLookup)
            {
                var l = new Languages.CSharp();
                l.Name = l.SafeStaticClassName(part.Key);
                foreach(var property in part.Value)
                {
                    if (int.TryParse(property[0], out _) )
                    {
                        property[0] = "Number" + property[0];
                    }
                    l.Properties.Add(new Languages.CSharp.Property() { Name = property[0], Type = property[1] });
                }
                string output = l.Generate();
                File.WriteAllText(directory + "/" + l.Name + ".cs", output);
            }
        }
    }
}
