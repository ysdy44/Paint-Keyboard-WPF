using System.Windows;
using System.Windows.Controls;

namespace Paint_Keyboard.Controls
{
    public sealed partial class MainCanvas : Canvas
    {

        public void StartedCursor(Point point)
        {
            ItemView selected = this.SelectItem(point);
            if (selected == null)
            {
                foreach (UIElement item3 in base.Children)
                {
                    if (item3 is ItemView item4)
                    {
                        if (item4.IsSelected) item4.IsSelected = false;
                    }
                }
                this.Mode = SelectionMode.None;
                this.ItemClick?.Invoke(this, null); // Delegate
            }
            else if (selected.IsSelected == false)
            {
                foreach (UIElement item3 in base.Children)
                {
                    if (item3 is ItemView item4)
                    {
                        item4.IsSelected = false;
                    }
                }
                selected.CachePosition();
                selected.IsSelected = true;
                this.Mode = SelectionMode.Single;
                this.ItemClick?.Invoke(this, selected.Export()); // Delegate
            }
            else
            {
                foreach (UIElement item3 in base.Children)
                {
                    if (item3 is ItemView item4)
                    {
                        if (item4.IsSelected) item4.CachePosition();
                    }
                }
                this.Mode = SelectionMode.Multiple;
            }
        }
        public void DeltaCursor(Point startingPoint, Point point)
        {
            if (this.Mode == SelectionMode.None) return;

            double x = point.X - startingPoint.X;
            double y = point.Y - startingPoint.Y;
            foreach (UIElement item2 in base.Children)
            {
                if (item2 is ItemView item)
                {
                    if (item.IsSelected) item.AddPosition(x, y);
                }
            }
        }
        public void CompletedCursor()
        {
            if (this.Mode == SelectionMode.None) return;

            foreach (UIElement item2 in base.Children)
            {
                if (item2 is ItemView item)
                {
                    if (item.IsSelected) item.Snap();
                }
            }
        }

    }
}