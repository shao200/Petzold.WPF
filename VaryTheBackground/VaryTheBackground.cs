using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Petzold.VaryTheBackground
{
    class VaryTheBackground : Window
    {
        SolidColorBrush brush = new SolidColorBrush(Colors.Black);

        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new VaryTheBackground());
        }
    }
}