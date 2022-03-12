using Paint_Keyboard.Elements;
using Paint_Keyboard.Model;
using Paint_Keyboard.Strings;
using System.Windows;
using System.Windows.Controls;

namespace Paint_Keyboard.Controls
{
    public partial class PropertyEditor : UserControl
    {

        //@Delegate 
        /// <summary>
        /// Occurs when clicked IconButton.
        /// </summary>
        public event RoutedEventHandler IconClick
        {
            remove => this.IconButton.Click -= value;
            add => this.IconButton.Click += value;
        }
        /// <summary>
        /// Occurs when clicked KeysButton.
        /// </summary>
        public event RoutedEventHandler KeysClick
        {
            remove => this.KeysButton.Click -= value;
            add => this.KeysButton.Click += value;
        }
        /// <summary>
        /// Occurs when clicked DeleteButton.
        /// </summary>
        public event RoutedEventHandler DeleteClick
        {
            remove => this.DeleteButton.Click -= value;
            add => this.DeleteButton.Click += value;
        }
        /// <summary>
        /// Occurs when LostFocus.
        /// </summary>
        public event RoutedEventHandler TitleLostFocus
        {
            remove => this.TitleTextBox.LostFocus -= value;
            add => this.TitleTextBox.LostFocus += value;
        }

        //@Content 
        public int Icon
        {
            get => this.icon;
            set
            {
                this.icon = value;
                if (value == 0)
                {
                    this.IconButton.Content = null;
                    this.IconTextBlock.Text = string.Empty;
                }
                else
                {
                    this.IconButton.Content =
                    this.IconTextBlock.Text = value.ToGlyph();
                }
            }
        }
        private int icon;

        public KeyList Keys
        {
            get => this.keys;
            set
            {
                this.keys = value;
                if (value == null)
                {
                    this.KeysButton.Content = null;
                    this.KeysTextBlock.Text = string.Empty;
                }
                else
                {
                    this.KeysButton.Content =
                    this.KeysTextBlock.Text = value.ToString();
                }
            }
        }
        private KeyList keys;

        public PropertyEditor()
        {
            this.InitializeComponent();
            this.TitleTextBox.KeyDown += (s, e) =>
            {
                switch (e.Key)
                {
                    case System.Windows.Input.Key.Return:
                        this.KeysButton.Focus();
                        break;
                    default:
                        break;
                }
            };
        }

        public void Construct(Item item)
        {
            if (item == null)
            {
                this.Clear();
                return;
            }

            this.Icon = item.Icon;
            this.Keys = item.Keys;

            this.Grid0.Visibility =
            this.StackPanel1.Visibility =
            this.StackPanel2.Visibility =
            this.StackPanel3.Visibility =
            this.DeleteButton.Visibility = Visibility.Visible;

            this.TitleTextBox.Text = item.GetTitle(LanguageResourceDictionary.Code);
        }

        public void Clear()
        {
            this.Icon = 0;
            this.Keys = null;

            this.Grid0.Visibility =
            this.StackPanel1.Visibility =
            this.StackPanel2.Visibility =
            this.StackPanel3.Visibility =
            this.DeleteButton.Visibility = Visibility.Hidden;

            this.TitleTextBox.Text = string.Empty;
        }

    }
}