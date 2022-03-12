using Paint_Keyboard.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Paint_Keyboard
{
    public static partial class XML
    {

        public static XElement SaveKeys(string elementName, IEnumerable<ScanCodeShort> scans)
        {
            return new XElement(elementName,
            (
                from scan
                in scans
                select new XElement("Key", scan)
            ));
        }

        public static IEnumerable<ScanCodeShort> LoadKeys(XElement element)
        {
            return
            from key
            in element.Elements("Key")
            select Enum.TryParse(key.Value, out ScanCodeShort scan) ? scan : default;
        }

    }
}