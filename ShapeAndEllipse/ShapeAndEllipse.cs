using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ShapeAndEllipse
{
    class ShapeAndEllipse : Window
    {
        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new ShapeAndEllipse());
        }

        public ShapeAndEllipse()
        {
            Title = "Shape And Ellipse";
            Ellipse ellipse = new Ellipse();
            ellipse.Fill = Brushes.AliceBlue;
            ellipse.StrokeThickness = 24;
            ellipse.Stroke = new LinearGradientBrush(Colors.CadetBlue, Colors.Chocolate, new Point(1, 0), new Point(0, 1));
            ellipse.Width = 300;
            ellipse.Height = 300;
            ellipse.HorizontalAlignment = HorizontalAlignment.Left;
            ellipse.VerticalAlignment = VerticalAlignment.Bottom;
            Content = ellipse;
        }
    }
}