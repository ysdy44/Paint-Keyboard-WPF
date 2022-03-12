using Paint_Keyboard.Model;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Paint_Keyboard
{
    public static partial class XML
    {

        public static XDocument SaveSolution(Solution solution)
        {
            return new XDocument
            (
                // Set the document definition for xml.
                new XDeclaration("1.0", "utf-8", "no"),
                new XElement
                (
                    "Root",
                    new XElement("Name", solution.Name),
                    new XElement("Width", solution.Width),
                    new XElement("Height", solution.Height),
                    new XElement
                    (
                        "Items",
                        from item
                        in solution.Items
                        select XML.SaveItem("Item", item)
                    )
                )
            );
        }

        public static Solution LoadSolution(XDocument document)
        {
            if (document.Element("Root") is XElement root)
            {
                Solution solution = new Solution();

                if (root.Element("Name") is XElement name) solution.Name = name.Value;
                if (root.Element("Width") is XElement width) solution.Width = (int)width;
                if (root.Element("Height") is XElement height) solution.Height = (int)height;
                if (root.Element("Items") is XElement items)
                {
                    solution.Items =
                    (
                        from item
                        in items.Elements()
                        select XML.LoadItem(item)
                    );
                }

                return solution;
            }
            else return null;
        }

    }
}