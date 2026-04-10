using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFileReaderGenerator
{
    public interface iLanguage
    {
        public iGeneratedClass GenerateClass(string classname, List<Property> properties);
        public iNoitaType GetNoitaType(string typename, string name);


        public class Property
        {
            public required string Name { get; set; }
            public required string Type { get; set; }
            public required iNoitaType NoitaType { get; set; }
        }

        public interface iNoitaType
        {
            public abstract string Type { get; set; }
            public string RealType { get; set; }
            public string Name { get; set; } // TODO: Name wrangle this
            public string Property();
            public string Save();
            public string Load();
        }

        public interface iGeneratedClass
        {
            string ClassName { get; set; }
            string ClassText { get; set; }
            string RecommendedFileName { get; set; }
        }
    }
}