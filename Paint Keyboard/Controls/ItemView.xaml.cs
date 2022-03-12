using Paint_Keyboard.Elements;
using Paint_Keyboard.Model;
using Paint_Keyboard.Strings;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Paint_Keyboard.Controls
{
    public partial class ItemView : UserControl
    {

        public bool IsSelected
        {
            get => this.isSelected;
            set
            {
                if (this.isSelected == value) return;
                this.isSelected = value;
                this.Border.BorderBrush = value ? Brushes.DodgerBlue : Brushes.Black;
            }
        }
        private bool isSelected;

        StringList StringList;
        KeyList KeyList;
        int Icon;

        double StartingLeft;
        double StartingTop;

        //@Construct
        /// <summary>
        /// Initializes a ItemView. 
        /// </summary> 
        public ItemView(Item item)
        {
            this.InitializeComponent();
            this.StringList = item.Strings;
            this.KeyList = item.Keys;
            this.Icon = item.Icon;
            this.GlyphTextBlock.Text = item.Icon.ToGlyph();
            this.TitleTextBlock.Text = item.GetTitle(LanguageResourceDictionary.Code);
            Canvas.SetLeft(this, item.Left * 70);
            Canvas.SetTop(this, item.Top * 70);
        }
        /// <summary>
        /// Initializes a ItemView. 
        /// </summary> 
        public ItemView(Point point)
        {
            this.InitializeComponent();
            double x = point.X - 70 / 2;
            double y = point.Y - 70 / 2;
            Canvas.SetLeft(this, x);
            Canvas.SetTop(this, y);
            this.StartingLeft = x;
            this.StartingTop = y;
        }

        public void CachePosition()
        {
            this.StartingLeft = Canvas.GetLeft(this);
            this.StartingTop = Canvas.GetTop(this);
        }
        public void AddPosition(double x, double y)
        {
            Canvas.SetLeft(this, this.StartingLeft + x);
            Canvas.SetTop(this, this.StartingTop + y);
        }
        public void Snap()
        {
            double x = Canvas.GetLeft(this);
            double y = Canvas.GetTop(this);
            Canvas.SetLeft(this, Snap(x) * 70);
            Canvas.SetTop(this, Snap(y) * 70);
        }

        public void SetKeys(KeyList keys)
        {
            if (keys == null)
                this.KeyList = new KeyList();
            else
                this.KeyList = keys.Clone();
        }
        public void SetGlyph(int icon)
        {
            this.Icon = icon;
            this.GlyphTextBlock.Text = icon.ToGlyph();
        }
        public void SetTitle(string title)
        {
            if (this.TitleTextBlock.Text == title) return;
            this.TitleTextBlock.Text = title;
            this.StringList = null;
        }
        public Item Export()
        {
            double x = Canvas.GetLeft(this);
            double y = Canvas.GetTop(this);
            return new Item
            {
                Strings = this.StringList?.Clone(),
                Keys = this.KeyList?.Clone(),
                Icon = this.Icon,
                Title = this.TitleTextBlock.Text,
                Left = Snap(x),
                Top = Snap(y)
            };
        }

        //@Static
        public static int Snap(double x)
        {
            if (x > 0)
            {
                return (int)((x + 70 / 2) / 70);
            }
            else
            {
                return (int)((x - 70 / 2) / 70);
            }
        }

    }
}