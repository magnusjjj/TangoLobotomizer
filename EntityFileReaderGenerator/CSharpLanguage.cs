using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFileReaderGenerator
{
    public class CSharpLanguage : iLanguage
    {
        string template = @"namespace GeneratedNoitaClasses;
public class NOITA_CLASSNAME : iLanguage.iNoitaType {
NOITA_PROPERTIES
    public void Load(){
NOITA_LOAD
    }
    public void Save()
NOITA_SAVE
    }
}
}";

        #region SanityChecking

        public static bool IsValidMemberName(string name)
        {
            return SyntaxFacts.IsValidIdentifier(name) &&
                   SyntaxFacts.GetKeywordKind(name) == SyntaxKind.None;
        }

        public static bool IsValidTypeName(string name)
        {
            return SyntaxFacts.IsValidIdentifier(name) &&
                   SyntaxFacts.GetKeywordKind(name) == SyntaxKind.None;
        }
        #endregion

        public string GenerateClass(string classname, List<iLanguage.Property> properties)
        {
            string returner = template;
            string propertystring = "";
            string loadstring = "";
            string savestring = "";

            if (!IsValidTypeName(classname))
            {
                throw new Exception("Invalid class name: " +  classname);
            }

            returner = returner.Replace("NOITA_CLASSNAME", classname);

            foreach(var property in properties)
            {
                propertystring += property.NoitaType.Property();
                loadstring += property.NoitaType.Load();
                savestring += property.NoitaType.Save();
            }

            returner = returner.Replace("NOITA_PROPERTIES", propertystring);
            returner = returner.Replace("NOITA_LOAD", loadstring);
            returner = returner.Replace("NOITA_SAVE", savestring);

            throw new NotImplementedException();
        }


    }
}
