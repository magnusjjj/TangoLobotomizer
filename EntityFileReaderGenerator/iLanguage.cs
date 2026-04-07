using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFileReaderGenerator
{
    public interface iLanguage
    {
        public string GenerateClass(string classname, List<Property> properties);

        public class Property
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public iNoitaType NoitaType { get; set; }
        }

        public interface iNoitaType
        {
            public string RealType { get; set; }
            public string Property();
            public string Save();
            public string Load();
        }
    }
}