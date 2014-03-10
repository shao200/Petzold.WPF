using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace ClickTheButton
{
    public class ClickTheButton : Window
    {
        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new ClickTheButton());
        }

        public ClickTheButton()
        {
            Title = "Click The Button";

            Button btn = new Button();
            btn.Content = "_Click me, please!";
            btn.Click += ButtonOnClick;
            btn.HorizontalAlignment = HorizontalAlignment.Center;
            btn.VerticalAlignment = VerticalAlignment.Center;
            btn.Width = 96;
            btn.Height = 96;

            btn.FontSize = 48;
            btn.FontFamily = new FontFamily("Times New Roman");

            btn.Background = Brushes.AliceBlue;
            btn.Foreground = Brushes.DarkSalmon;
            btn.BorderBrush = Brushes.Magenta;

            Content = btn;
        }

        void ButtonOnClick(object sender, RoutedEventArgs args)
        {
            MessageBox.Show("The button has been clicked and all is well.", Title);
        }
    }
}