using PetriNoitaLib.V2;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace EntityFileReaderGenerator
{
    internal class StaticObjectTypesGenerator
    {
        public static void Generate(string directory, iLanguage l)
        {
            Directory.CreateDirectory(directory);

            foreach (var part in StaticObjectTypes.ObjectFormatLookup)
            {
                List<iLanguage.Property> properties = new List<iLanguage.Property>();
                foreach(var property in part.Value)
                {
                    if (int.TryParse(property[0], out _) )
                    {
                        property[0] = "Number" + property[0];
                    }
                    properties.Add(new iLanguage.Property() { Name = property[0], Type = property[1], NoitaType = l.GetNoitaType(property[1], property[0]) });
                }

                string classname = part.Key;
                classname = classname.Replace("class ", "").Replace("struct ", "").Replace("::", "_").Replace(" *", "");

                iLanguage.iGeneratedClass iGeneratedClass = l.GenerateClass(classname, properties);
                File.WriteAllText(directory + "/" + iGeneratedClass.RecommendedFileName, iGeneratedClass.ClassText);
            }
        }
    }
}
