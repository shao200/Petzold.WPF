using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Petzold.DisplaySomeText
{
    class DisplaySomeText : Window
    {
        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new DisplaySomeText());
        }

        public DisplaySomeText()
        {
            Title = "Display Some Text";
            Content = "Content can be simple text!";
            FontFamily = new FontFamily("Times New Roman");
            FontSize = 32;
            FontStyle = FontStyles.Oblique;
            FontWeight = FontWeights.Bold;
            Brush brush = new LinearGradientBrush(Colors.Black, Colors.White, new Point(0, 0), new Point(1, 1));
            Background = brush;
            Foreground = brush;
        }
    }
}