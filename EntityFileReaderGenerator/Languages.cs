using Microsoft.CodeAnalysis.CSharp;
using PetriNoitaLib.V2;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EntityFileReaderGenerator
{
    public class Languages
    {
        public class CSharp
        {
            public string Name { get; set; }
            public List<Property> Properties { get; set; } = [];

            static string template =
@"namespace GeneratedNoitaClasses;
public class NOITA_CLASSNAME{
NOITA_PROPERTIES
}";

            public class Property
            {
                public string Name { get; set; }
                public string Type { get; set; }
            }

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

            public string Generate()
            {
                string propertystring = "";
                foreach(Property property in Properties)
                {
                    propertystring += "\tpublic " + MangleTypeName(property.Type) + " " + property.Name + "{ get; set; }\r\n";
                }

                string newtemplate = template;
                newtemplate = newtemplate.Replace("NOITA_PROPERTIES", propertystring);
                newtemplate = newtemplate.Replace("NOITA_CLASSNAME", Name);
                return newtemplate;
            }

            public string SafeStaticClassName(string type)
            {
                //if(Regex.IsMatch())
                if(Regex.IsMatch(type, "^class [a-zA-Z: \\*]*$"))
                {
                    return type.Substring("class ".Length).Replace("::", "_").Replace("*", "").Replace(" ", "");
                }

                if (Regex.IsMatch(type, "^struct [a-zA-Z:]*$"))
                {
                    return type.Substring("struct ".Length).Replace("::", "_");
                }

                if (IsValidTypeName(type))
                {
                    return type;
                }
                throw new Exception("Unexpected type name:" + type);
            }

            public string MangleTypeName(string type)
            {
                // First off, with these lucky few we can just straight up do a string->string
                Dictionary<string, string> static_mappings = new Dictionary<string, string> {
                    {"int", "int"},
                    {"float", "float"},
                    {"double", "double"},
                    {"string", "string"},
                    {"bool", "bool"},
                    {"class std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> >", "string" },
                    {"unsigned __int64", "UInt64"},
                    {"__int64", "Int64"},
                    {"unsigned short", "UInt16"},
                    {"class PixelSprite *", "object?"},
                    {"unsigned int", "UInt32"},
                    {"struct SpriteStains *", "SPECIAL_IGNORE" },
                    {"struct UintArrayInline", "List<UInt32>" },
                    {"class ceng::CColorFloat", "CColorFloat" },
                    {"special texture", "SpecialTexture" }
                };

                if (static_mappings.ContainsKey(type))
                {
                    return static_mappings[type];
                }


                // Next up, check if it's a typename that works, and isn't reserved or something.
                if (!IsValidTypeName(type))
                {
                    if (type.StartsWith("class "))
                    {
                        string realtype = type.Substring("class ".Length);
                        if (IsValidTypeName(realtype))
                        {
                            return realtype;
                        }
                        else
                        {
                            string vec2 = "class ceng::math::CVector2<";

                            if (type.StartsWith(vec2))
                            {
                                string real_type = type[vec2.Length..^1];
                                return "List<" + real_type + ">";
                            }

                            string vectormatch = "class std::vector<";
                            if (type.StartsWith(vectormatch))
                            {
                                string true_type = "";
                                int bracket_num = 0;
                                for (int i = vectormatch.Length; i < type.Length; i++)
                                {
                                    if (type[i] == '<')
                                        bracket_num++;

                                    if (type[i] == '>')
                                        bracket_num--;

                                    if (type[i] == ',' && bracket_num == 0)
                                    {
                                        true_type = type[vectormatch.Length..i];
                                        return "List<" + MangleTypeName(true_type) + ">";
                                    }
                                }
                            }

                            /*if (type.StartsWith("))
                            {
                                return "hoi"+type.Substring("class ceng::CColorFloat".Length);
                            }*/

                            throw new Exception("Unexpected class type name: " + type);
                        }
                    }

                    if (type.StartsWith("struct LensValue<"))
                    {
                        return type["struct LensValue<".Length..^1];
                    }

                    if (type.EndsWith("::Enum"))
                    {
                        return type["enum ".Length .. ^"::Enum".Length];
                    }

                    string formmatch = "struct ceng::math::CXForm<";

                    if (type.StartsWith(formmatch))
                    {
                        string real_type = type[formmatch.Length..^1];
                        return "CXForm<" + real_type + ">";
                    }

                    if(type.StartsWith("struct ") && StaticObjectTypes.ObjectFormatLookup.ContainsKey(type))
                    {
                        string realtype = type["struct ".Length..];
                        realtype = realtype.Replace("::", "_");
                        if(!IsValidTypeName(realtype))
                        {
                            throw new Exception("Typename for struct not valid: " + realtype);
                        } else
                        {
                            return realtype;
                        }
                    }

                    throw new Exception("Unexpected type name: " + type);
                } else
                {
                    return type;
                }

                throw new Exception("Unexpected type name: " + type);
                return "";
            }
        }
    }
}
