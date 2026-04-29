using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using PetriNoitaLib.V2;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EntityFileReaderGenerator.CSharpGenerator
{
    public class CSharpLanguage : iLanguage
    {
        string template = @"namespace GeneratedNoitaClasses;
public class NOITA_CLASSNAME : NOITA_ADDITIONAL_CLASS iNoitaType<NOITA_CLASSNAME>{
NOITA_PROPERTIES
    public void Read(NoitaStream s){
NOITA_LOAD
    }
    public void Write(NoitaStream s){
NOITA_SAVE
    }
}";

        public static List<string> GeneratedClasses = new List<string>();

        public static void GenerateFactory(string filename, string classname)
        {
            string factorytemplate =  @"namespace GeneratedNoitaClasses;
public class NOITA_CLASSNAME {
    public static iNoitaType GetGeneratedClass(string generatedname){
        switch(generatedname){
NOITA_SWITCH_ROWS
            default:
                throw new Exception(""Could not find class: "" + generatedname);
        }
    }
}";
            string class_row = "";
            foreach(string s in GeneratedClasses) {
                class_row += "\t\t\t case " + "\"" + s + "\":\r\n\t\t\t\treturn new " + s + "();\r\n";   
            }

            File.WriteAllText(filename, factorytemplate.Replace("NOITA_CLASSNAME", classname).Replace("NOITA_SWITCH_ROWS", class_row));
        }

        public static void GenerateJsonSerializer(string filename)
        {
            string factorytemplate = @"using System.Text.Json.Serialization;
namespace GeneratedNoitaClasses;
[JsonSourceGenerationOptions(WriteIndented = true)]
[JsonSerializable(typeof(EntityFile))]
NOITA_SERIALIZABLES
public partial class NoitaCSharpJSONSerializer : JsonSerializerContext {
}";
            string serializables = "";
            foreach (string classname in GeneratedClasses)
            {
                serializables += "[JsonSerializable(typeof(" + classname + "))]\r\n";
            }
            string returner = factorytemplate.Replace("NOITA_SERIALIZABLES", serializables);

            File.WriteAllText(filename, returner);
        }

        public static void GenerateComponentBase(string filename)
        {
            string factorytemplate = @"using System.Text.Json.Serialization;
namespace GeneratedNoitaClasses;
[JsonPolymorphic(TypeDiscriminatorPropertyName = ""ComponentName2"")]
NOITA_SERIALIZABLES
public partial class NoitaComponentBase : iNoitaType {
    public string ComponentName { get; set; } = """";

    void iNoitaType.Read(NoitaStream s)
    {
        throw new NotImplementedException();
    }

    void iNoitaType.Write(NoitaStream s)
    {
        throw new NotImplementedException();
    }
}";
            string serializables = "";
            foreach (string classname in GeneratedClasses)
            {
                if(classname.EndsWith("Component"))
                { 
                    serializables += "[JsonDerivedType(typeof(" + classname + "), typeDiscriminator: \"" + classname + "\")]\r\n";
                }
            }
            string returner = factorytemplate.Replace("NOITA_SERIALIZABLES", serializables);

            File.WriteAllText(filename, returner);
        }

        #region SanityChecking


        public static bool IsValidMemberName(string name)
        {
            var syntaxkind = SyntaxFacts.GetKeywordKind(name);
            return SyntaxFacts.IsValidIdentifier(name) &&
                   SyntaxFacts.GetKeywordKind(name) == SyntaxKind.None;
        }

        public static bool IsValidTypeName(string name)
        {
            return (SyntaxFacts.IsValidIdentifier(name) &&
                   SyntaxFacts.GetKeywordKind(name) == SyntaxKind.None);
        }

        public static bool IsPrimitive(string name)
        {
            List<string> types = ["bool", "byte", "sbyte", "char", "decimal", "double", "float", "int", "uint", "nint", "nuint", "long", "ulong", "short", "ushort", "string", "object", "delegate", "dynamic"];
            return types.Contains(name);
        }
        #endregion

        iLanguage.iGeneratedClass iLanguage.GenerateClass(string classname, List<iLanguage.Property> properties, string additional_class)
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
            returner = returner.Replace("NOITA_ADDITIONAL_CLASS", additional_class);

            if(!GeneratedClasses.Contains(classname)) GeneratedClasses.Add(classname);

            return new GeneratedClass() { ClassName = classname, ClassText = returner, RecommendedFileName = classname + ".cs"};
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
                { "struct ceng::math::CXForm<float>",  (string type, string name) => new SimpleNoitaProperty() { Type="NoitaCXForm<NoitaFloat>", Name = name, RealType = type}},
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

            if(StaticObjectTypes.ObjectFormatLookup.ContainsKey(typename))
            {
                string sanitized_name = typename.Replace("class ", "").Replace("struct ", "").Replace("::", "_").Replace("*", "").Replace(" ", "");

                if (!IsValidTypeName(sanitized_name))
                {
                    throw new Exception("Invalid *new* typename: " + sanitized_name + " was " + typename);
                } else
                {
                    return new SimpleNoitaProperty() { Type= sanitized_name, Name = name, RealType = typename};
                }
            }

            if(typename.StartsWith("struct LensValue<"))
            {
                return new SimpleNoitaProperty() { Type="NoitaLensValue<"+ GetNoitaType(typename["struct LensValue<".Length..^1], name).Type + ">", RealType = typename, Name = name };
            }

            if(typename.StartsWith("enum ") && typename.EndsWith("::Enum")) // Sanity checking is done in SchemaFileClassGenerator. Enums are always 4 bytes, as verified by grepping the xml files.
            {
                return new SimpleNoitaProperty() { Type = "NoitaUInt", Name = name, RealType = typename };
            }

            if (typename.StartsWith("class ceng::math::CVector2<")) // Always a basic number format, but we sanity check it next
            {
                string innertype = typename["class ceng::math::CVector2<".Length..^1];
                if (!Regex.IsMatch(innertype, "^[a-zA-Z0-9]*$"))
                    throw new Exception("Unexpected inner CVector2 type name: " + innertype);
                innertype = GetNoitaType(innertype, name).Type;
                return new SimpleNoitaProperty{ Type="NoitaCVector2<"+innertype+">", Name = name, RealType = typename};
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
                        return new SimpleNoitaProperty() { Type = "NoitaVector<" + true_type + ">", Name = name, RealType = typename };
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

        abstract class NoitaTypeGenerator : iLanguage.iNoitaTypeGenerator
        {
            public string RealType { get; set; } = "";
            public string Name { get; set; } = "";
            public abstract string Load();
            public virtual string Property() => "public " + Type + " " + Name + " { get; set; } = new();";
            public abstract string Save();
            public abstract string Type { get; set; }
        }

        class SimpleNoitaProperty : NoitaTypeGenerator
        {
            public required override string Type { get; set; }
            public override string Load() => Name + ".Read(s);";
            public override string Save() => Name + ".Write(s);";
        }

        

        class NoitaMissingClass : NoitaTypeGenerator
        {
            public required override string Type { get; set; }
            public override string Load() => "throw new NotImplementedException(\"Type " + Type +  " not implemented\");";
            public override string Save() => "throw new NotImplementedException(\"Type " + Type + " not implemented\");";
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
