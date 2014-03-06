using System;
using System.Windows;

namespace Petzold.RenderTheGraphic
{
    class ReplaceMainWindow : Window
    {
        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new ReplaceMainWindow());
        }

        public ReplaceMainWindow()
        {
            Title = "Render The Graphic";
            SimpleEllipse ellipse = new SimpleEllipse();
            Content = ellipse;
        }
    }
}