using Paint_Keyboard.Model;
using System.Xml.Linq;

namespace Paint_Keyboard
{
    public static partial class XML
    {

        public static XElement SaveItem(string elementName, Item item)
        {
            XElement element = new XElement(elementName);
            if (item.Strings != null) element.Add(XML.SaveStrings("Strings", item.Strings));
            if (item.Keys != null) element.Add(XML.SaveKeys("Keys", item.Keys));
            element.Add(new XAttribute("Icon", item.Icon));
            if (item.Title != null) element.Add(new XAttribute("Title", item.Title));
            element.Add(new XAttribute("Left", item.Left));
            element.Add(new XAttribute("Top", item.Top));

            return element;
        }

        public static Item LoadItem(XElement element)
        {
            Item item = new Item();
            if (element.Attribute("Icon") is XAttribute icon) item.Icon = (int)icon;
            if (element.Attribute("Title") is XAttribute title) item.Title = title.Value;
            if (element.Attribute("Left") is XAttribute left) item.Left = (int)left;
            if (element.Attribute("Top") is XAttribute top) item.Top = (int)top;
            if (element.Element("Keys") is XElement keys) item.Keys = new KeyList(XML.LoadKeys(keys));
            if (element.Element("Strings") is XElement strings) item.Strings = XML.LoadStrings(strings);

            return item;
        }

    }
}