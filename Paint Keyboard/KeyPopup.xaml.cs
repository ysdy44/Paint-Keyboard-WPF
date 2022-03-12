using Paint_Keyboard.Elements;
using Paint_Keyboard.Model;
using Paint_Keyboard.Controls;
using System.Windows;
using System.Windows.Media;

namespace Paint_Keyboard
{
    public partial class KeyPopup : PopupBase
    {

        //@Delegate 
        /// <summary>
        /// Occurs when clicked EditButton.
        /// </summary>
        public event RoutedEventHandler EditClick
        {
            remove => this.EditButton.Click -= value;
            add => this.EditButton.Click += value;
        }

        public bool IsCtrl;
        public bool IsShift;
        public bool IsAlt;

        public KeyPopup()
        {
            this.InitializeComponent();
            this.CloseButton.Click += (s, e) => base.IsOpen = false;
            this.CtrlButton.Click += (s, e) =>
            {
                if (this.IsCtrl)
                {
                    this.IsCtrl = false;
                    this.CtrlBrush.Color = Colors.Transparent;
                    InputSimulator.KeyUp(ScanCodeShort.Ctrl);
                }
                else
                {
                    this.IsCtrl = true;
                    this.CtrlBrush.Color = Colors.DodgerBlue;
                    InputSimulator.KeyDown(ScanCodeShort.Ctrl);
                }
            };
            this.ShiftButton.Click += (s, e) =>
            {
                if (this.IsShift)
                {
                    this.IsShift = false;
                    this.ShiftBrush.Color = Colors.Transparent;
                    InputSimulator.KeyUp(ScanCodeShort.Shift);
                }
                else
                {
                    this.IsShift = true;
                    this.ShiftBrush.Color = Colors.DodgerBlue;
                    InputSimulator.KeyDown(ScanCodeShort.Shift);
                }
            };
            this.AltButton.Click += (s, e) =>
            {
                if (this.IsAlt)
                {
                    this.IsAlt = false;
                    this.AltBrush.Color = Colors.Transparent;
                    InputSimulator.KeyUp(ScanCodeShort.Alt);
                }
                else
                {
                    this.IsAlt = true;
                    this.AltBrush.Color = Colors.DodgerBlue;
                    InputSimulator.KeyDown(ScanCodeShort.Alt);
                }
            };
        }

        public void Construct(Solution solution)
        {
            this.Canvas.Children.Clear();

            if (solution == null || solution.Items == null)
            {
                this.NameRun.Text = string.Empty;
                this.Canvas.Width = 3 * 70;
                this.Canvas.Height = 3 * 70;
                base.Width = 1 + 3 * 70 + 1;
                base.Height = 1 + 32 + 3 * 70 + 16 + 1;
            }
            else
            {
                this.NameRun.Text = solution.Name == null ? string.Empty : solution.Name;
                this.Canvas.Width = solution.Width * 70;
                this.Canvas.Height = solution.Height * 70;
                base.Width = 1 + solution.Width * 70 + 1;
                base.Height = 1 + 32 + solution.Height * 70 + 16 + 1;

                if (solution.Items != null)
                {
                    foreach (Item item in solution.Items)
                    {
                        this.Canvas.Children.Add(new ItemButton(item));
                    }
                }
            }
        }

    }
}