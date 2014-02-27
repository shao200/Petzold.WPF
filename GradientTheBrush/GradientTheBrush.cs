using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Petzold.GradientTheBrush
{
    public class GradientTheBrush : Window
    {
        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new GradientTheBrush());
        }

        public GradientTheBrush()
        {
            Title = "Gradient the Brush";
            LinearGradientBrush brush = new LinearGradientBrush(Colors.Red, Colors.Blue, new Point(0, 0), new Point(1, 1));
            Background = brush;
            brush.SpreadMethod = GradientSpreadMethod.Reflect;
        }
    }
}