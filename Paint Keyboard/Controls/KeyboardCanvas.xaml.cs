using Paint_Keyboard.Elements;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Paint_Keyboard.Controls
{
    public partial class KeyboardCanvas : Canvas
    {

        //@Delegate 
        /// <summary>
        /// Occurs when clicked item.
        /// </summary>
        public event EventHandler<ScanCodeShort> ItemClick;

        public KeyboardCanvas()
        {
            this.InitializeComponent();
            foreach (UIElement item in base.Children)
            {
                if (item is Button button)
                {
                    button.Click += this.Button_Click;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                if (button.Tag is ScanCodeShort scan)
                {
                    this.ItemClick?.Invoke(this, scan); // Delegate
                }
            }
        }

    }
}