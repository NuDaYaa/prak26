using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ShapesApp
{
    public class RectangleFigure
    {
        private Rectangle rectangle;

        public RectangleFigure(double width, double height, Point position)
        {
            rectangle = new Rectangle
            {
                Width = width,
                Height = height,
                Fill = Brushes.Blue,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };

            Canvas.SetLeft(rectangle, position.X);
            Canvas.SetTop(rectangle, position.Y);
        }

        public void Show(Canvas canvas)
        {
            if (!canvas.Children.Contains(rectangle))
            {
                canvas.Children.Add(rectangle);
            }
        }

        public void Hide(Canvas canvas)
        {
            if (canvas.Children.Contains(rectangle))
            {
                canvas.Children.Remove(rectangle);
            }
        }

        public void Move(double x, double y)
        {
            Canvas.SetLeft(rectangle, x);
            Canvas.SetTop(rectangle, y);
        }
    }
}
