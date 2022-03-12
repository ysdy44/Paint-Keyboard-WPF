using Paint_Keyboard.Model;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Paint_Keyboard.Controls
{
    public enum SelectionMode
    {
        None,
        Single,
        Multiple,
    }

    public sealed partial class MainCanvas : Canvas
    {

        //@Delegate 
        /// <summary>
        /// Occurs when clicked item.
        /// </summary>
        public event EventHandler<Item> ItemClick;

        SelectionMode Mode;


        #region DependencyProperty


        /// <summary> Gets or sets the W of<see cref = "MainCanvas" />. </summary>
        public int W
        {
            get => (int)base.GetValue(WProperty);
            set => base.SetValue(WProperty, value);
        }
        /// <summary> Identifies the <see cref = "MainCanvas.W" /> dependency property. </summary>
        public static readonly DependencyProperty WProperty = DependencyProperty.Register(nameof(W), typeof(int), typeof(MainCanvas), new PropertyMetadata(1, (sender, e) =>
        {
            MainCanvas control = (MainCanvas)sender;

            if (e.NewValue is int value)
            {
                control.Width = value * 70;
            }
        }));


        /// <summary> Gets or sets the H of<see cref = "MainCanvas" />. </summary>
        public int H
        {
            get => (int)base.GetValue(HProperty);
            set => base.SetValue(HProperty, value);
        }
        /// <summary> Identifies the <see cref = "MainCanvas.H" /> dependency property. </summary>
        public static readonly DependencyProperty HProperty = DependencyProperty.Register(nameof(H), typeof(int), typeof(MainCanvas), new PropertyMetadata(1, (sender, e) =>
        {
            MainCanvas control = (MainCanvas)sender;

            if (e.NewValue is int value)
            {
                control.Height = value * 70;
            }
        }));


        #endregion


        public void Construct(IEnumerable<Item> items)
        {
            base.Children.Clear();
            if (items == null) return;
            foreach (Item item in items)
            {
                this.Add(item);
            }

            foreach (UIElement item3 in base.Children)
            {
                if (item3 is ItemView item4)
                {
                    item4.IsSelected = true;
                    this.ItemClick?.Invoke(this, item4.Export()); // Delegate
                    break;
                }
            }
        }
        public void Add(Item item)
        {
            base.Children.Add(new ItemView(item));
        }


        public void SetKeys(KeyList keys)
        {
            foreach (UIElement item2 in base.Children)
            {
                if (item2 is ItemView item3)
                {
                    if (item3.IsSelected)
                    {
                        item3.SetKeys(keys);
                        break;
                    }
                }
            }
        }
        public void SetIcon(int icon)
        {
            foreach (UIElement item2 in base.Children)
            {
                if (item2 is ItemView item3)
                {
                    if (item3.IsSelected)
                    {
                        item3.SetGlyph(icon);
                        break;
                    }
                }
            }
        }
        public void SetTitle(string title)
        {
            foreach (UIElement item2 in base.Children)
            {
                if (item2 is ItemView item3)
                {
                    if (item3.IsSelected)
                    {
                        item3.SetTitle(title);
                        break;
                    }
                }
            }
        }


        public void Remove()
        {
            ItemView item = null;
            foreach (UIElement item2 in base.Children)
            {
                if (item2 is ItemView item3)
                {
                    if (item3.IsSelected)
                    {
                        item = item3;
                        break;
                    }
                }
            }
            base.Children.Remove(item);
        }
        public ItemView SelectItem(Point point)
        {
            ItemView selected = null;
            foreach (UIElement item2 in base.Children)
            {
                if (item2 is ItemView item)
                {
                    double left = MainCanvas.GetLeft(item2);
                    double top = MainCanvas.GetTop(item2);
                    Rect rect = new Rect(left, top, 70, 70);
                    if (rect.Contains(point))
                    {
                        selected = item;
                    }
                }
            }
            return selected;
        }


        public IEnumerable<Item> Export()
        {
            foreach (UIElement item2 in base.Children)
            {
                if (item2 is ItemView item)
                {
                    yield return item.Export();
                }
            }
        }

    }
}