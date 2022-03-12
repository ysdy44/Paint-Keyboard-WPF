using Paint_Keyboard.Model;
using System.Timers;
using System.Windows;

namespace Paint_Keyboard
{
    public partial class MainWindow : Window
    {

        //@ViewModel
        Solution Solution => App.Solution;

        readonly KeyPopup KeyPopup = new KeyPopup();
        readonly Timer Timer = new Timer
        {
            Interval = 50
        };

        Vector StartingPosition;
        Vector Position
        {
            get => new Vector(base.Left, base.Top);
            set
            {
                base.Left = value.X;
                base.Top = value.Y;
            }
        }

        public MainWindow()
        {
            this.InitializeComponent();
            base.SourceInitialized += (s, e) => NativeMethod.Unfocus(this);

            this.KeyPopup.Construct(this.Solution);
            this.KeyPopup.EditClick += (s, e) =>
            {
                if (this.Solution == null) return;

                base.Topmost = false;
                //base.Hide();
                this.KeyPopup.Hide();

                bool? reslut = new EditWindow
                {
                    Owner = this
                }.ShowDialog();
                this.KeyPopup.Construct(this.Solution);
                XML.SaveSolutionFile(this.Solution);

                this.ShowPopup();
                //base.Show();
                base.Topmost = true;
            };

            this.Timer.Elapsed += (s, e) =>
            {
                this.Timer.Stop();

                base.Dispatcher.Invoke(() =>
                {
                    if (this.KeyPopup.IsOpen)
                    {
                        this.KeyPopup.Hide();
                    }
                    else
                    {
                        this.ShowPopup();
                    }
                });
            };

            this.Thumb.TouchDown += (s, e) =>
            {
                this.Timer.Stop();
                this.Timer.Start();
            };
            this.Thumb.PreviewMouseDown += (s, e) =>
            {
                this.Timer.Stop();
                this.Timer.Start();
            };

            this.Thumb.DragStarted += (s, e) =>
            {
                this.StartingPosition = this.Position;
            };
            this.Thumb.DragDelta += (s, e) =>
            {
                if (this.Timer.Enabled)
                {
                    this.Timer.Stop();
                }
                this.StartingPosition += new Vector
                {
                    X = e.HorizontalChange,
                    Y = e.VerticalChange
                };
                this.Position = this.StartingPosition;
            };
            this.Thumb.DragCompleted += (s, e) =>
            {
                if (this.KeyPopup.IsOpen)
                {
                    this.ShowPopup();
                }
            };
        }
        private void ShowPopup() => this.KeyPopup.Show(this.Position + new Vector((base.Width - this.KeyPopup.Width) / 2, base.Height));

    }
}