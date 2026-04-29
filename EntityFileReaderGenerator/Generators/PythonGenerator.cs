using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using PetriNoitaLib.V2;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EntityFileReaderGenerator.Generators
{
    internal class PythonGenerator : iLanguage
    {
        public static readonly List<string> BaseTypes = ["NoitaBool", "NoitaFloat", "NoitaDouble", "NoitaInt64", "NoitaUInt64", "NoitaInt", "NoitaUInt", "NoitaShort", "NoitaUShort", "NoitaString", "NoitaLensValue", "NoitaCVector2", "NoitaCXForm", "NoitaVector", "NoitaSpecialTexture", "NoitaUintArrayInline", "MissingClassConfigPendingPortal", "MissingClassConfigNpcParty", "MissingClassConfigCutThroughWorld"];

        //  NOITA_ADDITIONAL_CLASS iNoitaType<NOITA_CLASSNAME>{
        string template = @"NOITA_IMPORTS
from NoitaStream import NoitaStream
@dataclass
class NOITA_CLASSNAME:
NOITA_PROPERTIES    
    def Read(self, s:NoitaStream):
NOITA_LOAD    
    def Write(self, s:NoitaStream):
NOITA_SAVE
";

        public static List<string> GeneratedClasses = new List<string>();


        public static void GenerateFactory(string filename, string classname)
        {
            string factorytemplate = @"IMPORT_STATEMENTS
class NOITA_CLASSNAME:
    def GetGeneratedClass(generatedname:str):
NOITA_SWITCH_ROWS
";
            string class_row = "";
            string importstatements = "";
            foreach (string s in GeneratedClasses)
            {
                class_row += "        if generatedname == \"" + s + "\": return " + s + "()\r\n";
                if (s.EndsWith("Component")) { 
                    importstatements += "from GeneratedClasses.Components." + s + " import " + s + "\r\n";
                } else
                {
                    importstatements += "from GeneratedClasses." + s + " import " + s + "\r\n";
                }
            }
            string root = Path.GetDirectoryName(filename);
            if (!File.Exists(root + "/__init__.py"))
                File.WriteAllText(root + "/__init__.py", "");
            if (!File.Exists(root + "/Components/__init__.py"))
                File.WriteAllText(root + "/Components/__init__.py", "");
            File.WriteAllText(filename, factorytemplate.Replace("NOITA_CLASSNAME", classname).Replace("NOITA_SWITCH_ROWS", class_row).Replace("IMPORT_STATEMENTS", importstatements));
        }

        public bool IsValidIdentifier(string s) // Simplified testing, though incorrect
        {
            return Regex.IsMatch(s, "^[A-Za-z_]*[A-Za-z_0-9]*$");
        }

        iLanguage.iGeneratedClass iLanguage.GenerateClass(string classname, List<iLanguage.Property> properties, string additional_class)
        {
            string returner = template;
            string propertystring = "";
            string loadstring = "";
            string savestring = "";
            string imports = "";


            if (!IsValidIdentifier(classname)) // Todo: Sanity check this thing
            {
                throw new Exception("Invalid class name: " + classname);
            }

            returner = returner.Replace("NOITA_CLASSNAME", classname);
            List<string> imported = new List<string>();

            imports += "from dataclasses import dataclass, field\r\n";

            foreach (var property in properties)
            {
                string innertype = property.NoitaType is NoitaWithInner ? ((NoitaWithInner)property.NoitaType).InnerType : "";


                if (property.NoitaType.Type == "")
                    continue;

                if (!imported.Contains(property.NoitaType.Type) || (innertype != "" && !imported.Contains(innertype))) { 
                    if(property.NoitaType.Type.EndsWith("Component"))
                    {
                        imports += "from GeneratedClasses.Components." + property.NoitaType.Type + " import " + property.NoitaType.Type + "\r\n";
                    } else if (BaseTypes.Contains(property.NoitaType.Type)){
                        imports += "from BasicNoitaTypes import " + property.NoitaType.Type + "\r\n";
                        if(innertype != "")
                        {
                            if (BaseTypes.Contains(innertype))
                                imports += "from BasicNoitaTypes import " + innertype + "\r\n";
                            else
                                imports += "from GeneratedClasses." + innertype + " import " + innertype + "\r\n";
                        }
                    }
                    else
                    {
                        imports += "from GeneratedClasses." + property.NoitaType.Type + " import " + property.NoitaType.Type +  "\r\n";
                    }
                    imported.Add(property.NoitaType.Type);
                    if(innertype != "" && !imported.Contains(innertype)) imported.Add(innertype);
                }

                propertystring += "    " + property.NoitaType.Property() + "\r\n";
                loadstring += "        " + property.NoitaType.Load() + "\r\n";
                savestring += "        " + property.NoitaType.Save() + "\r\n";
            }

            if(loadstring == "")
                loadstring = "        pass\r\n";

            if (savestring == "")
                savestring = "        pass\r\n";

            returner = returner.Replace("NOITA_PROPERTIES", propertystring);
            returner = returner.Replace("NOITA_LOAD", loadstring);
            returner = returner.Replace("NOITA_SAVE", savestring);
            returner = returner.Replace("NOITA_ADDITIONAL_CLASS", additional_class);
            returner = returner.Replace("NOITA_IMPORTS", imports);

            if (!GeneratedClasses.Contains(classname)) GeneratedClasses.Add(classname);

            return new GeneratedClass() { ClassName = classname, ClassText = returner, RecommendedFileName = classname + ".py" };
        }

        public iLanguage.iNoitaTypeGenerator GetNoitaType(string typename, string name)
        {
            Dictionary<string, Func<string, string, iLanguage.iNoitaTypeGenerator>> OneToOneConversions = new Dictionary<string, Func<string, string, iLanguage.iNoitaTypeGenerator>> {
                // Simple types, just a name of a 
                { "bool", (string type, string name) => new SimpleNoitaProperty() {             Type="NoitaBool", Name = name, RealType = type } },
                { "float", (string type, string name) => new SimpleNoitaProperty() {            Type="NoitaFloat", Name = name, RealType = type } },
                { "double", (string type, string name) => new SimpleNoitaProperty() {           Type="NoitaDouble", Name = name, RealType = type } },
                { "int", (string type, string name) => new SimpleNoitaProperty() {              Type="NoitaInt", Name = name, RealType = type } },
                { "unsigned int", (string type, string name) => new SimpleNoitaProperty() {     Type="NoitaUInt", Name = name, RealType = type } },
                { "short", (string type, string name) => new SimpleNoitaProperty() {            Type="NoitaShort", Name = name, RealType = type } },
                { "unsigned short", (string type, string name) => new SimpleNoitaProperty() {   Type="NoitaUShort", Name = name, RealType = type } },
                { "__int64", (string type, string name) => new SimpleNoitaProperty() {          Type="NoitaInt64", Name = name, RealType = type } },
                { "unsigned __int64", (string type, string name) => new SimpleNoitaProperty {   Type="NoitaUInt64", Name = name, RealType = type } },
                { "string", (string type, string name) => new SimpleNoitaProperty {             Type="NoitaString", Name = name, RealType = type } },
                { "struct UintArrayInline",  (string type, string name) => new SimpleNoitaProperty() {  Type="NoitaUintArrayInline", Name = name, RealType = type}},
                { "struct ceng::math::CXForm<float>",  (string type, string name) => new NoitaWithInner() { Type="NoitaCXForm", InnerType="NoitaFloat", Name = name, RealType = type}},
                { "special texture",  (string type, string name) => new SimpleNoitaProperty() { Type="NoitaSpecialTexture", Name = name, RealType = type }},
                { "class std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> >", (string type, string name) => new SimpleNoitaProperty() { Type="NoitaString", Name = name, RealType = type } },
                // All the more complicated types but simple translations
                { "struct SpriteStains *",  (string type, string name) => new NoitaEmpty() { Name = name, RealType = type } },
                { "class std::map<class std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> >,class std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> >,struct std::less<class std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> > >,class std::allocator<struct std::pair<class std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> > const ,class std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> > > > >",  (string type, string name) => new NoitaEmpty() { Name = name, RealType = type } }, // TODO: ACTUAL IMPLEMENTATION
            };

            if (OneToOneConversions.ContainsKey(typename))
            {
                return OneToOneConversions[typename](typename, name);
            }

            if (StaticObjectTypes.ObjectFormatLookup.ContainsKey(typename))
            {
                string sanitized_name = typename.Replace("class ", "").Replace("struct ", "").Replace("::", "_").Replace("*", "").Replace(" ", "");

                if (!IsValidIdentifier(sanitized_name))
                {
                    throw new Exception("Invalid *new* typename: " + sanitized_name + " was " + typename);
                }
                else
                {
                    return new SimpleNoitaProperty() { Type = sanitized_name, Name = name, RealType = typename };
                }
            }

            if (typename.StartsWith("struct LensValue<"))
            {
                return new NoitaWithInner() { Type = "NoitaLensValue", InnerType = GetNoitaType(typename["struct LensValue<".Length..^1], name).Type, RealType = typename, Name = name };
                //return new SimpleNoitaProperty() { Type = "NoitaLensValue<" + GetNoitaType(typename["struct LensValue<".Length..^1], name).Type + ">", RealType = typename, Name = name };
            }

            if (typename.StartsWith("enum ") && typename.EndsWith("::Enum")) // Sanity checking is done in SchemaFileClassGenerator. Enums are always 4 bytes, as verified by grepping the xml files.
            {
                return new SimpleNoitaProperty() { Type = "NoitaUInt", Name = name, RealType = typename };
            }

            if (typename.StartsWith("class ceng::math::CVector2<")) // Always a basic number format, but we sanity check it next
            {
                string innertype = typename["class ceng::math::CVector2<".Length..^1];
                if (!Regex.IsMatch(innertype, "^[a-zA-Z0-9]*$"))
                    throw new Exception("Unexpected inner CVector2 type name: " + innertype);
                innertype = GetNoitaType(innertype, name).Type;
                return new NoitaWithInner() { Type = "NoitaCVector2", InnerType = innertype, RealType = typename, Name = name };
                //return new SimpleNoitaProperty { Type = "NoitaCVector2<" + innertype + ">", Name = name, RealType = typename };
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
                        true_type = GetNoitaType(typename[vectormatch.Length..i], name).Type;
                        if (!IsValidIdentifier(true_type))
                        {
                            throw new Exception("Invalid inner type name: " + true_type);
                        }
                        return new NoitaWithInner() { Type = "NoitaVector", InnerType = true_type, Name = name, RealType = typename};
                        //return new SimpleNoitaProperty() { Type = "NoitaVector<" + true_type + ">", Name = name, RealType = typename };
                    }
                }
            }

            if (typename.StartsWith("class "))
            {
                string newclassname = "MissingClass" + typename["class ".Length..];
                if (!IsValidIdentifier(newclassname))
                {
                    throw new NotImplementedException("Wrong classname for missing class: " + newclassname);
                }

                return new NoitaMissingClass() { Type = newclassname, Name = name, RealType = typename };
            }

            throw new NotImplementedException();
        }

        class GeneratedClass : iLanguage.iGeneratedClass
        {
            public string ClassName { get; set; } = "FORGOT TO SET CLASSNAME";
            public string ClassText { get; set; } = "FORGOT TO SET CLASSTEXT";
            public string RecommendedFileName { get; set; } = "FORGOT TO SET RECOMMENDED FILENAME";
        }


        /* 
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
         */

        abstract class NoitaTypeGenerator : iLanguage.iNoitaTypeGenerator
        {
            public string RealType { get; set; } = "";
            public string Name { get; set; } = "";
            public abstract string Load();
            public virtual string Property() => Name + ":" + Type + " = field(default_factory=" + Type +")";
            public abstract string Save();
            public abstract string Type { get; set; }
        }

        class SimpleNoitaProperty : NoitaTypeGenerator
        {
            public required override string Type { get; set; }
            public override string Load() => "self." + Name + ".Read(s)";
            public override string Save() => "self." + Name + ".Write(s)";
        }

        class NoitaWithInner : NoitaTypeGenerator
        {
            public override string Type { get; set; }
            public required string InnerType { get; set; }

            public override string Property() => Name + ":" + Type + " = field(default_factory=lambda: " + Type + "("+InnerType+"))";

            public override string Load() => "self." + Name + ".Read(s)";
            public override string Save() => "self." + Name + ".Write(s)";
        }


        class NoitaMissingClass : NoitaTypeGenerator
        {
            public required override string Type { get; set; }
            public override string Load() => "raise NotImplementedException";
            public override string Save() => "raise NotImplementedException";
        }

        class NoitaEmpty : NoitaTypeGenerator // For spritestain, never gets stored
        {
            public override string Type { get; set; } = "";
            public override string Load() => "";
            public override string Property() => "";
            public override string Save() => "";
        }
    }
}
