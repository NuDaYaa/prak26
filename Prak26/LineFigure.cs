using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ShapesApp
{
    public class LineFigure
    {
        private Line line;

        public LineFigure(Point startPoint, Point endPoint)
        {
            line = new Line
            {
                X1 = startPoint.X,
                Y1 = startPoint.Y,
                X2 = endPoint.X,
                Y2 = endPoint.Y,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };
        }

        public void Show(Canvas canvas)
        {
            if (!canvas.Children.Contains(line))
            {
                canvas.Children.Add(line);
            }
        }

        public void Hide(Canvas canvas)
        {
            if (canvas.Children.Contains(line))
            {
                canvas.Children.Remove(line);
            }
        }

        public void Move(double x, double y)
        {
            double deltaX = x - line.X1;
            double deltaY = y - line.Y1;

            line.X1 += deltaX;
            line.Y1 += deltaY;
            line.X2 += deltaX;
            line.Y2 += deltaY;
        }
    }
}
