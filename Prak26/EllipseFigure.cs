using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ShapesApp
{
    public class EllipseFigure
    {
        private Ellipse ellipse;

        public EllipseFigure(double radiusX, double radiusY, Point position)
        {
            ellipse = new Ellipse
            {
                Width = 2 * radiusX,
                Height = 2 * radiusY,
                Fill = Brushes.Green,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };

            Canvas.SetLeft(ellipse, position.X - radiusX);
            Canvas.SetTop(ellipse, position.Y - radiusY);
        }

        public void Show(Canvas canvas)
        {
            if (!canvas.Children.Contains(ellipse))
            {
                canvas.Children.Add(ellipse);
            }
        }

        public void Hide(Canvas canvas)
        {
            if (canvas.Children.Contains(ellipse))
            {
                canvas.Children.Remove(ellipse);
            }
        }

        public void Move(double x, double y)
        {
            Canvas.SetLeft(ellipse, x - ellipse.Width / 2);
            Canvas.SetTop(ellipse, y - ellipse.Height / 2);
        }
    }
}
