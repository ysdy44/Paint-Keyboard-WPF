using Paint_Keyboard.Elements;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Paint_Keyboard.Model
{
    public class KeyList : List<ScanCodeShort>
    {

        public KeyList() { }
        public KeyList(IEnumerable<ScanCodeShort> collection) : base(collection) { }

        public KeyList Clone() => new KeyList(this.ToList());

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            bool has = false;
            foreach (ScanCodeShort scan in this)
            {
                if (has) sb.Append("+");
                has = true;

                sb.Append(KeyList.GetString(scan));
            }

            return sb.ToString();
        }

        private static string GetString(ScanCodeShort scan)
        {
            switch (scan)
            {
                case ScanCodeShort.Ctrl: return "Ctrl";
                case ScanCodeShort.Alt: return "Alt";
                case ScanCodeShort.Return: return "Enter";
                case ScanCodeShort.Escape: return "Esc";
                case ScanCodeShort.Capital: return "Caps";
                case ScanCodeShort.Back: return "Backspace";

                case ScanCodeShort.Delete: return "Del";
                case ScanCodeShort.Insert: return "Ins";
                case ScanCodeShort.Prior: return "Page Up";
                case ScanCodeShort.Next: return "Page Down";


                case ScanCodeShort.OemQuestion: return "?";
                case ScanCodeShort.OemPeriod: return ".";
                case ScanCodeShort.OemComma: return ",";

                case ScanCodeShort.OemMinus: return "-";
                case ScanCodeShort.OemPlus: return "+";
                case ScanCodeShort.OemOpenBrackets: return "[";
                case ScanCodeShort.OemCloseBrackets: return "]";
                case ScanCodeShort.OemQuotes: return "'";
                case ScanCodeShort.OemSemicolon: return ";";


                case ScanCodeShort.D0: return "0";
                case ScanCodeShort.D1: return "1";
                case ScanCodeShort.D2: return "2";
                case ScanCodeShort.D3: return "3";
                case ScanCodeShort.D4: return "4";
                case ScanCodeShort.D5: return "5";
                case ScanCodeShort.D6: return "6";
                case ScanCodeShort.D7: return "7";
                case ScanCodeShort.D8: return "8";
                case ScanCodeShort.D9: return "9";

                case ScanCodeShort.Left: return "←";
                case ScanCodeShort.Right: return "→";
                case ScanCodeShort.Up: return "↑";
                case ScanCodeShort.Down: return "↓";

                default: return scan.ToString();
            }
        }

    }
}