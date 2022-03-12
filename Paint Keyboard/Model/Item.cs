using Paint_Keyboard.Strings;

namespace Paint_Keyboard.Model
{
    public class Item
    {
        public StringList Strings { get; set; }
        public KeyList Keys { get; set; }
        public int Icon { get; set; }
        public string Title { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }
        public string GetTitle(LangCode code)
        {
            if (this.Strings != null) return this.Strings[code];
            else if (this.Title == null) return string.Empty;
            else return this.Title;
        }
    }
}