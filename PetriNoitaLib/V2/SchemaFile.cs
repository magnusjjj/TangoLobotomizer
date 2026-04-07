using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetriNoitaLib.V2
{
    public class SchemaFile
    {
        // This will hold the parsed data of the schema. Components, and the sizes of different types read from the schema.
        private Dictionary<string, Component> Components = [];
        public Dictionary<string, int> TypeSizes = [];

        // This is the base tag in the file. Looks like <Component component_name="">
        public class Component
        {
            public string Name { get; set; } = "";
            public List<ComponentVar> ComponentVars { get; set; } = [];
        }

        // These are children of Component's. Different parameters of them. Look like <Var name="use_probability" size="4" type="int" >
        public class ComponentVar
        {
            public string Name { get; set; } = "";
            public string Type { get; set; } = "";
            public int Size { get; set; }
        }

        public List<ComponentVar> GetComponentVars(string componentname)
        {
            return Components[componentname].ComponentVars;
        }

        // This loads a schema file, and parses them into Components and TypeSizes
        public void Load(string hash)
        {
            string schema_content = File.ReadAllText("C:\\Program Files (x86)\\Steam\\steamapps\\common\\Noita\\data\\schemas\\" + hash + ".xml"); // Todo: Replace static noita path

            // We can't parse the data using standard XML functions, it's invalid XML. Instead, we use HtmlAgilityPack, which is more forgiving.
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(schema_content);

            // Loading the <Component>'s
            foreach (var node in doc.DocumentNode.ChildNodes[0].ChildNodes)
            {
                if (node.Name == "#text") // Ignore text nodes. Always one before and after each tag.
                    continue;
                if (node.Name != "component") // HtmlAgilityPack tolower()'s tag name automatically. No schema should have anything but Component's directly below the root tag
                    throw new Exception("Unknown document node type: " + node.Name);
                if (node.Attributes.Count != 1) // If a Component has more than three attributes, then bail. Just for future version protection I guess :).
                    throw new Exception("Component with unknown parameters: " + string.Join(" ", node.Attributes));

                // Sanity check complete. Add it to the array.
                Components[node.Attributes["component_name"].Value] = new Component() { Name = node.Attributes["component_name"].Value };

                // Loop through it's children to find it's <Var'>
                foreach (var attributeNode in node.ChildNodes)
                {
                    if (attributeNode.Name == "#text") // Ignore text nodes. Always one before and after each tag.
                        continue;
                    if (attributeNode.Name != "var") // HtmlAgilityPack tolower()'s tag name automatically. No Component should have anything but <Var>'s directly below the root tag
                        throw new Exception("Unknown component attribute type: " + attributeNode.Name);
                    if (attributeNode.Attributes.Count != 3) // It should always have three attributes
                        throw new Exception("Component attribute with unknown parameters: " + string.Join(" ", node.Attributes));

                    string name = attributeNode.Attributes["name"].Value;
                    string type = attributeNode.Attributes["type"].Value;
                    int size = int.Parse(attributeNode.Attributes["size"].Value);

                    // Add the var to the component lookup
                    Components[node.Attributes["component_name"].Value].ComponentVars.Add(new ComponentVar() {
                        Name = name,
                        Type = type,
                        Size = size
                    });

                    TypeSizes[type] = size; // Apparantly this is fine, snail's code does it.

                    // Sanity check. The sizes of types should be the same.
                    /*if (TypeSizes.ContainsKey(name) && TypeSizes[name] != size) { 
                        // Scrap this sanity check.
                        //throw new Exception("Found two different sizes for variable type " + name + " first size: " + TypeSizes[name] + " second size: " + size);
                    } else*/ //if(!TypeSizes.ContainsKey(name)) // Otherwise, adding in new size
//                    {
//                        TypeSizes.Add(name, size);
//                    }
                }
            }
        }
    }
}
