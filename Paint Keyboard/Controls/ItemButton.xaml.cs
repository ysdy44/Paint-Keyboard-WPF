using Paint_Keyboard.Elements;
using Paint_Keyboard.Model;
using Paint_Keyboard.Strings;
using System.Windows.Controls;

namespace Paint_Keyboard.Controls
{
    public partial class ItemButton : Button
    {
        public ItemButton(Item item)
        {
            this.InitializeComponent();

            if (item == null) return;

            this.GlyphTextBlock.Text = item.Icon.ToGlyph();
            this.TitleTextBlock.Text = item.GetTitle(LanguageResourceDictionary.Code);
            Canvas.SetLeft(this, item.Left * 70);
            Canvas.SetTop(this, item.Top * 70);

            if (item.Keys == null) return;

            this.ToolTip.Content = item.Keys.ToString();
            base.Click += (s, e) => InputSimulator.Send(item.Keys);
        }

    }
}