using Paint_Keyboard.Elements;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace Paint_Keyboard.Controls
{
    public partial class IconListView : ListView
    {

        private readonly IList<int> IconFontItems = IconFontCharacter.CreateSegoeUISymbolCharacterCodesList().ToList();

        public int SelectedIcon
        {
            get
            {
                int index = base.SelectedIndex;
                if (index < 0) return 0;
                return this.IconFontItems[index];
            }
            set
            {
                if (value <= 0)
                {
                    base.SelectedIndex = -1;
                    base.Focus();
                }
                else
                {
                    for (int i = 0; i < this.IconFontItems.Count; i++)
                    {
                        int item = this.IconFontItems[i];
                        if (item == value)
                        {
                            base.SelectedIndex = i;
                            base.Focus();
                            break;
                        }
                    }
                }
            }
        }

        public IconListView()
        {
            this.InitializeComponent();
            base.ItemsSource = this.IconFontItems;
        }

    }
}