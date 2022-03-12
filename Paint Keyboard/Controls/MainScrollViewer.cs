using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Paint_Keyboard.Controls
{
    public enum ToolType
    {
        Cursor,
        //View,
        //Edit,
        Add,
    }

    public class MainScrollViewer : ScrollViewer
    {

        public ToolType Type { get; set; }
        bool IsMouseDown = false;
        Point StartingPoint;

        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            if (base.Content is MainCanvas canvas)
            {
                base.CaptureMouse();

                this.IsMouseDown = true;

                Point point = e.GetPosition(canvas);
                this.StartingPoint = point;

                switch (this.Type)
                {
                    case ToolType.Cursor:
                        canvas.StartedCursor(point);
                        break;
                    case ToolType.Add:
                        canvas.StartedAdd(point);
                        break;
                    default:
                        break;
                }
            }
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (this.IsMouseDown == false) return;

            if (base.Content is MainCanvas canvas)
            {
                Point point = e.GetPosition(canvas);
                switch (this.Type)
                {
                    case ToolType.Cursor:
                        canvas.DeltaCursor(this.StartingPoint, point);
                        break;
                    case ToolType.Add:
                        canvas.DeltaAdd(this.StartingPoint, point);
                        break;
                    default:
                        break;
                }
            }
        }
        protected override void OnMouseUp(MouseButtonEventArgs e)
        {
            if (this.IsMouseDown == false) return;
            this.IsMouseDown = false;

            if (base.Content is MainCanvas canvas)
            {
                base.ReleaseMouseCapture();

                switch (this.Type)
                {
                    case ToolType.Cursor:
                        canvas.CompletedCursor();
                        break;
                    case ToolType.Add:
                        canvas.CompletedAdd();
                        break;
                    default:
                        break;
                }
            }
        }

    }
}