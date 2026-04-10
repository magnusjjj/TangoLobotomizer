using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using PetriNoitaLib.V2;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EntityFileReaderGenerator
{
    public class CSharpLanguage : iLanguage
    {
        string template = @"namespace GeneratedNoitaClasses;
public class NOITA_CLASSNAME {
NOITA_PROPERTIES
    public void Load(NoitaStream s){
NOITA_LOAD
    }
    public void Save(NoitaStream s){
NOITA_SAVE
    }
}";

        #region SanityChecking



        public static bool IsValidMemberName(string name)
        {
            var syntaxkind = SyntaxFacts.GetKeywordKind(name);
            return SyntaxFacts.IsValidIdentifier(name) &&
                   SyntaxFacts.GetKeywordKind(name) == SyntaxKind.None;
        }

        public static bool IsValidTypeName(string name)
        {
            return IsPrimitive(name) || (SyntaxFacts.IsValidIdentifier(name) &&
                   SyntaxFacts.GetKeywordKind(name) == SyntaxKind.None);
        }

        public static bool IsPrimitive(string name)
        {
            List<string> types = ["bool", "byte", "sbyte", "char", "decimal", "double", "float", "int", "uint", "nint", "nuint", "long", "ulong", "short", "ushort", "string", "object", "delegate", "dynamic"];
            return types.Contains(name);
        }
        #endregion

        iLanguage.iGeneratedClass iLanguage.GenerateClass(string classname, List<iLanguage.Property> properties)
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
                propertystring += "\t" + property.NoitaType.Property() + "\r\n";
                loadstring += "\t\t" + property.NoitaType.Load() + "\r\n";
                savestring += "\t\t" + property.NoitaType.Save() + "\r\n";
            }

            returner = returner.Replace("NOITA_PROPERTIES", propertystring);
            returner = returner.Replace("NOITA_LOAD", loadstring);
            returner = returner.Replace("NOITA_SAVE", savestring);

            return new GeneratedClass() { ClassName = classname, ClassText = returner, RecommendedFileName = classname + ".cs"};
        }

        public iLanguage.iNoitaType GetNoitaType(string typename, string name)
        {
            Dictionary<string, Func<string, string, iLanguage.iNoitaType>> OneToOneConversions = new Dictionary<string, Func<string, string, iLanguage.iNoitaType>> {
                { "bool", (string type, string name) => new NoitaBool() { Name = name, RealType = type } },
                { "float", (string type, string name) => new NoitaFloat() { Name = name, RealType = type } },
                { "double", (string type, string name) => new NoitaDouble() { Name = name, RealType = type } },
                { "int", (string type, string name) => new NoitaInt() { Name = name, RealType = type } },
                { "unsigned int", (string type, string name) => new NoitaUInt() { Name = name, RealType = type } },
                { "short", (string type, string name) => new NoitaShort() { Name = name, RealType = type } },
                { "unsigned short", (string type, string name) => new NoitaUShort() { Name = name, RealType = type } },
                { "__int64", (string type, string name) => new NoitaInt64() { Name = name, RealType = type } },
                { "unsigned __int64", (string type, string name) => new NoitaUInt64() { Name = name, RealType = type } },
                { "string", (string type, string name) => new NoitaString() { Name = name, RealType = type } },
                { "struct SpriteStains *",  (string type, string name) => new NoitaEmpty() { Name = name, RealType = type } },
                { "class std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> >", (string type, string name) => new NoitaString() { Name = name, RealType = type } },
                { "class std::map<class std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> >,class std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> >,struct std::less<class std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> > >,class std::allocator<struct std::pair<class std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> > const ,class std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> > > > >",  (string type, string name) => new NoitaEmpty() { Name = name, RealType = type } }, // TODO: ACTUAL IMPLEMENTATION
                { "struct UintArrayInline",  (string type, string name) => new NoitaVector() { Name = name, RealType = type, InnerType = "UInt32" }},
                { "struct ceng::math::CXForm<float>",  (string type, string name) => new NoitaCXForm() { Name = name, RealType = type, InnerType = "float" }},
                { "special texture",  (string type, string name) => new NoitaSpecialTexture() { Name = name, RealType = type }}
            };

            if (OneToOneConversions.ContainsKey(typename))
            {
                return OneToOneConversions[typename](typename, name);
            }

            if(StaticObjectTypes.ObjectFormatLookup.ContainsKey(typename))
            {
                string sanitized_name = typename.Replace("class ", "").Replace("struct ", "").Replace("::", "_").Replace("*", "").Replace(" ", "");

                if (!IsValidTypeName(sanitized_name))
                {
                    throw new Exception("Invalid *new* typename: " + sanitized_name + " was " + typename);
                } else
                {
                    return new NoitaClassOrStruct() { Name = name, RealType = typename, SanitizedTypeName = sanitized_name };
                }
            }

            if(typename.StartsWith("struct LensValue<"))
            {
                return new NoitaLensValue() { InnerType = typename["struct LensValue<".Length..^1], RealType = typename, Name = name };
            }

            if(typename.StartsWith("enum ") && typename.EndsWith("::Enum")) // Sanity checking is done in SchemaFileClassGenerator. Enums are always 4 bytes, as verified by grepping the xml files.
            {
                return new NoitaUInt() { Name = name, RealType = typename };
            }

            if (typename.StartsWith("class ceng::math::CVector2<")) // Always a basic number format, but we sanity check it next
            {
                string innertype = typename["class ceng::math::CVector2<".Length..^1];
                if (!Regex.IsMatch(innertype, "^[a-zA-Z0-9]*$"))
                    throw new Exception("Unexpected inner CVector2 type name: " + innertype);
                return new NoitaCVector2() { Name = name, RealType = typename, InnerType = innertype };
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
                        if(!IsValidTypeName(true_type))
                        {
                            true_type = GetNoitaType(true_type, name).Type;
                            if (!IsValidTypeName(true_type))
                            {
                                throw new Exception("Invalid inner type name: " + true_type);
                            }
                        }
                        return new NoitaVector() { InnerType = true_type, Name = name, RealType = typename };
                    }
                }
            }

            if(typename.StartsWith("class "))
            {
                string newclassname = "MissingClass" + typename["class ".Length..];
                if (!IsValidTypeName(newclassname))
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

        abstract class NoitaType : iLanguage.iNoitaType
        {
            public string RealType { get; set; }
            public string Name { get; set; }
            public abstract string Load();
            public virtual string Property() => "public " + Type + " " + Name + " { get; set; }";
            public abstract string Save();
            public abstract string Type { get; set; }
        }

        class NoitaBool : NoitaType
        {
            public override string Type { get; set; } = "bool";
            public override string Load() => Name + " = s.ReadBool();";
            public override string Save() => "s.WriteBool(" + Name + ");";
        }

        class NoitaFloat : NoitaType
        {
            public override string Type { get; set; } = "float";
            public override string Load() => Name + " = s.ReadBeFloat();";
            public override string Save() => "s.WriteBeFloat(" + Name + ");";
        }

        class NoitaDouble : NoitaType
        {
            public override string Type { get; set; } = "double";
            public override string Load() => Name + " = s.ReadBeDouble();";
            public override string Save() => "s.WriteBeDouble(" + Name + ");";
        }

        class NoitaInt64 : NoitaType
        {
            public override string Type { get; set; } = "Int64";
            public override string Load() => Name + " = s.ReadBeInt64();";
            public override string Save() => "s.WriteBeInt64(" + Name + ");";
        }

        class NoitaUInt64 : NoitaType
        {
            public override string Type { get; set; } = "UInt64";
            public override string Load() => Name + " = s.ReadBeUInt64();";
            public override string Save() => "s.WriteBeUInt64(" + Name + ");";
        }

        class NoitaInt : NoitaType
        {
            public override string Type { get; set; } = "Int32";
            public override string Load() => Name + " = s.ReadBeInt32();";
            public override string Save() => "s.WriteBeInt32(" + Name + ");";
        }

        class NoitaUInt : NoitaType
        {
            public override string Type { get; set; } = "UInt32";
            public override string Load() => Name + " = s.ReadBeUInt32();";
            public override string Save() => "s.WriteBeUInt32(" + Name + ");";
        }

        class NoitaShort : NoitaType
        {
            public override string Type { get; set; } = "Int16";
            public override string Load() => Name + " = s.ReadBeInt16();";
            public override string Save() => "s.WriteBeInt16(" + Name + ");";
        }

        class NoitaUShort : NoitaType
        {
            public override string Type { get; set; } = "UInt16";
            public override string Load() => Name + " = s.ReadBeUInt16();";
            public override string Save() => "s.WriteBeUInt16(" + Name + ");";
        }

        class NoitaEmpty : NoitaType // For spritestain, never gets stored
        {
            public override string Type { get; set; } = "";
            public override string Load() => "";
            public override string Property() => "";
            public override string Save() => "";
        }

        class NoitaString : NoitaType
        {
            public override string Type { get; set; } = "string";
            public override string Load() => Name + " = s.ReadBeString();";
            public override string Save() => "s.WriteBeString(" + Name + ");";
        }

        class NoitaClassOrStruct : NoitaType
        {
            public override string Type { get => SanitizedTypeName; set; }
            public override string Load() => Name + ".Load(s);";
            public override string Save() => Name + ".Write(s);";
            public required string SanitizedTypeName { get; set; }
        }

        class NoitaLensValue : NoitaType
        {
            public override string Type { get => "LensValue<" + InnerType + ">"; set; }
            public override string Load() => Name + ".Load(s);";
            public override string Save() => Name + ".Write(s);";
            public required string InnerType { get; set; }
        }

        class NoitaCVector2 : NoitaType
        {
            public override string Type { get => "CVector2<" + InnerType + ">"; set; }
            public override string Load() => Name + ".Load(s);";
            public override string Save() => Name + ".Write(s);";
            public required string InnerType { get; set; }
        }

        class NoitaCXForm : NoitaType
        {
            public override string Type { get => "CXForm<" + InnerType + ">"; set; }
            public override string Load() => Name + ".Load(s);";
            public override string Save() => Name + ".Write(s);";
            public required string InnerType { get; set; }
        }

        class NoitaVector : NoitaType
        {
            public override string Type { get => "List<" + InnerType + ">"; set; }
            public override string Load() => Name + " = [];\r\nUInt32 len = s.ReadBeUInt32();\r\nfor(int i = 0; i < len; i++) {\r\n " + Name + ".Add("+InnerType+".Load(s));\r\n}";
            public override string Save() => "s.WriteBeUInt32("+Name+".Length);\r\nforeach(var item in " + Name +"){ "+Name+".Write(s);\r\n}";
            public required string InnerType { get; set; }
        }

        class NoitaSpecialTexture : NoitaType
        {
            public override string Type { get; set; } = "SpecialTexture";
            public override string Load() => Name + ".Load(s);";
            public override string Save() => Name + ".Write(s);";
        }

        class NoitaMissingClass : NoitaType
        {
            public required override string Type { get; set; }
            public override string Load() => "throw new NotImplementedException(\"Type " + Type +  " not implemented\");";
            public override string Save() => "throw new NotImplementedException(\"Type " + Type + " not implemented\");";
        }
    }
}
