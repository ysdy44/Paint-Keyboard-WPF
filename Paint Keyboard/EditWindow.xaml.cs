using Paint_Keyboard.Controls;
using Paint_Keyboard.Model;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Paint_Keyboard
{
    public partial class EditWindow : Window
    {

        //@ViewModel
        Solution Solution => App.Solution;

        public EditWindow()
        {
            this.InitializeComponent();

            base.Closed += (s, e) => this.Export(this.Solution);
            base.Loaded += (s, e) =>
            {
                this.Construct(this.Solution);
                base.Activate();
            };

            this.WidthComboBox.ItemsSource =
            this.HeightComboBox.ItemsSource =
                Enumerable.Range(1, 10).ToList();

            this.ToolListView.SelectionChanged += (s, e) =>
            {
                this.ScrollViewer.Type = (ToolType)this.ToolListView.SelectedIndex;
            };

            this.Canvas.ItemClick += (s, item) =>
            {
                if (item == null)
                    this.Editor.Clear();
                else
                    this.Editor.Construct(item);
            };

            this.Editor.IconClick += (s, e) =>
            {
                this.IconGrid.Visibility = Visibility.Visible;
                this.IconListView.SelectedIcon = this.Editor.Icon;
            };
            this.Editor.KeysClick += (s, e) =>
            {
                this.KeyboardGrid.Visibility = Visibility.Visible;
                this.KeyboardTextBlock.Text = this.Editor.Keys == null ? string.Empty : this.Editor.Keys.ToString();
            };
            this.Editor.DeleteClick += (s, e) =>
            {
                this.Editor.Clear();
                this.Canvas.Remove();
            };
            this.Editor.TitleLostFocus += (s, e) =>
            {
                if (s is TextBox textBox)
                {
                    string title = textBox.Text;
                    this.Canvas.SetTitle(title);
                }
            };


            this.IconButton.Click += (s, e) =>
            {
                int icon = this.IconListView.SelectedIcon;
                this.Editor.Icon = icon;
                this.Canvas.SetIcon(icon);
                this.IconGrid.Visibility = Visibility.Hidden;
            };


            this.KeyboardCanvas.ItemClick += (s, scan) =>
            {
                if (this.Editor.Keys == null) this.Editor.Keys = new KeyList();
                this.Editor.Keys.Add(scan);
                this.KeyboardTextBlock.Text = this.Editor.Keys.ToString();
            };
            this.KeyboardRemoveButton.Click += (s, scan) =>
            {
                if (this.Editor.Keys == null) return;
                if (this.Editor.Keys.Count == 0) return;

                this.Editor.Keys.RemoveAt(this.Editor.Keys.Count - 1);
                this.KeyboardTextBlock.Text = this.Editor.Keys.ToString();
            };
            this.KeyboardButton.Click += (s, scan) =>
            {
                KeyList keys = this.Editor.Keys;
                this.Editor.Keys = keys;
                this.Canvas.SetKeys(keys);
                this.KeyboardGrid.Visibility = Visibility.Hidden;
            };


            this.DefaultButton.Click += (s, e) => this.Construct(XML.ConstructSolutionFile(SolutionType.None));
            this.KritaButton.Click += (s, e) => this.Construct(XML.ConstructSolutionFile(SolutionType.Krita));
            this.SAIPaintButton.Click += (s, e) => this.Construct(XML.ConstructSolutionFile(SolutionType.SAI_Paint));
            this.AffinityPhotoButton.Click += (s, e) => this.Construct(XML.ConstructSolutionFile(SolutionType.Affinity_Photo));
        }

        private void Export(Solution solution)
        {
            if (solution == null) return;
            solution.Name = this.NameTextBox.Text;
            solution.Width = this.Canvas.W;
            solution.Height = this.Canvas.H;
            solution.Items = this.Canvas.Export().OrderBy(c => c.Left + c.Top * 1024); // Order by Position
        }

        private void Construct(Solution solution)
        {
            if (solution == null || solution.Items == null)
            {
                this.NameTextBox.Text = string.Empty;
                this.Canvas.Construct(null);

                this.WidthComboBox.SelectedItem = 3;
                this.HeightComboBox.SelectedItem = 3;
            }
            else
            {
                this.NameTextBox.Text = solution.Name == null ? string.Empty : solution.Name;
                this.Canvas.Construct(solution.Items);

                this.WidthComboBox.SelectedItem = solution.Width;
                this.HeightComboBox.SelectedItem = solution.Height;
            }
        }

    }
}