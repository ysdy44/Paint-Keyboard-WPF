using System.Windows;
using System.Windows.Controls;

namespace Paint_Keyboard.Controls
{
    public sealed partial class MainCanvas : Canvas
    {

        public void StartedAdd(Point point)
        {
            foreach (UIElement item3 in base.Children)
            {
                if (item3 is ItemView item4)
                {
                    if (item4.IsSelected) item4.IsSelected = false;
                }
            }

            base.Children.Add(new ItemView(point)
            {
                IsSelected = true,
            });
            this.ItemClick?.Invoke(this, new Model.Item()); // Delegate
        }
        public void DeltaAdd(Point startingPoint, Point point)
        {
            foreach (UIElement item2 in base.Children)
            {
                if (item2 is ItemView item)
                {
                    if (item.IsSelected) item.AddPosition(point.X - startingPoint.X, point.Y - startingPoint.Y);
                }
            }
        }
        public void CompletedAdd()
        {
            foreach (UIElement item2 in base.Children)
            {
                if (item2 is ItemView item)
                {
                    if (item.IsSelected)
                    {
                        item.Snap();
                    }
                }
            }
        }

    }
}