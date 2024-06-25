using System;
using System.Reflection;
using System.Windows;

namespace ShapesApp
{
    public partial class MainWindow : Window
    {
        private LineFigure lineFigure;
        private RectangleFigure rectangleFigure;
        private EllipseFigure ellipseFigure;
        private string selectedFigure; // Переменная для хранения выбранной фигуры

        public MainWindow()
        {
            InitializeComponent();

            // Создаем экземпляры фигур
            lineFigure = new LineFigure(new Point(50, 50), new Point(150, 150));
            rectangleFigure = new RectangleFigure(100, 50, new Point(200, 50));
            ellipseFigure = new EllipseFigure(50, 50, new Point(350, 100));

            // Инициализируем выбранную фигуру (начально выбрана Линия)
            selectedFigure = "Line";
            lineFigure.Show(MyCanvas);
        }

        // Кнопка Show Line
        private void LineButton_Click(object sender, RoutedEventArgs e)
        {
            selectedFigure = "Line";
            lineFigure.Show(MyCanvas);
            rectangleFigure.Hide(MyCanvas);
            ellipseFigure.Hide(MyCanvas);
        }

        // Кнопка Show Rectangle
        private void RectangleButton_Click(object sender, RoutedEventArgs e)
        {
            selectedFigure = "Rectangle";
            lineFigure.Hide(MyCanvas);
            rectangleFigure.Show(MyCanvas);
            ellipseFigure.Hide(MyCanvas);
        }

        // Кнопка Show Ellipse
        private void EllipseButton_Click(object sender, RoutedEventArgs e)
        {
            selectedFigure = "Ellipse";
            lineFigure.Hide(MyCanvas);
            rectangleFigure.Hide(MyCanvas);
            ellipseFigure.Show(MyCanvas);
        }

        // Кнопка Show
        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            switch (selectedFigure)
            {
                case "Line":
                    lineFigure.Show(MyCanvas);
                    break;
                case "Rectangle":
                    rectangleFigure.Show(MyCanvas);
                    break;
                case "Ellipse":
                    ellipseFigure.Show(MyCanvas);
                    break;
                default:
                    MessageBox.Show("Please select a figure first.", "No Figure Selected", MessageBoxButton.OK, MessageBoxImage.Warning);
                    break;
            }
        }

        // Кнопка Hide All
        private void HideAllButton_Click(object sender, RoutedEventArgs e)
        {
            lineFigure.Hide(MyCanvas);
            rectangleFigure.Hide(MyCanvas);
            ellipseFigure.Hide(MyCanvas);
        }

        // Кнопка Move
        private void MoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(XCoordinateTextBox.Text, out double x) && double.TryParse(YCoordinateTextBox.Text, out double y))
            {
                switch (selectedFigure)
                {
                    case "Line":
                        lineFigure.Move(x, y);
                        break;
                    case "Rectangle":
                        rectangleFigure.Move(x, y);
                        break;
                    case "Ellipse":
                        ellipseFigure.Move(x, y);
                        break;
                    default:
                        MessageBox.Show("Please select a figure first.", "No Figure Selected", MessageBoxButton.OK, MessageBoxImage.Warning);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please enter valid coordinates.", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        // Кнопка Выход
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        // Кнопка О программе
        private void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            string message = "Практическая работа №26. Создание иерархии классов.";
            MessageBox.Show(message, "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
