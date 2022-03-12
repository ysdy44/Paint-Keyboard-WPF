using Paint_Keyboard.Elements;
using System.Windows;
using System.Windows.Controls;

namespace Paint_Keyboard.Controls
{
    public partial class ItemIcon : UserControl
    {

        #region DependencyProperty


        /// <summary> Gets or sets the Icon of<see cref = "ItemIcon" />. </summary>
        public int Icon
        {
            get => (int)base.GetValue(IconProperty);
            set => base.SetValue(IconProperty, value);
        }
        /// <summary> Identifies the <see cref = "ItemIcon.Icon" /> dependency property. </summary>
        public static readonly DependencyProperty IconProperty = DependencyProperty.Register(nameof(Icon), typeof(int), typeof(ItemIcon), new PropertyMetadata(1, (sender, e) =>
        {
            ItemIcon control = (ItemIcon)sender;

            if (e.NewValue is int value)
            {
                control.GlyphTextBlock.Text = value.ToGlyph();
                control.CodeKeyTextBlock.Text = value.ToCodeKey();
            }
        }));


        #endregion

        //@Construct
        /// <summary>
        /// Initializes a ItemIcon. 
        /// </summary> 
        public ItemIcon()
        {
            this.InitializeComponent();
        }

    }
}