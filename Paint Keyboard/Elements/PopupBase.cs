using System.Windows;
using System.Windows.Controls.Primitives;

namespace Paint_Keyboard.Elements
{
    public class PopupBase : Popup
    {
        public void Hide() => base.IsOpen = false;
        public void Show(Vector position)
        {
            this.Move(position);
            base.IsOpen = true;
        }
        public void Move(Vector position)
        {
            base.HorizontalOffset = position.X;
            base.VerticalOffset = position.Y;
        }
    }
}