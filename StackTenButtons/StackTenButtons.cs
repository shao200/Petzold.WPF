using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace StackTenButtons
{
    class StackTenButtons : Window
    {
        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new StackTenButtons());
        }

        public StackTenButtons()
        {
            Title = "Stack Ten Buttons";

            StackPanel stack = new StackPanel();
            Content = stack;
            stack.Margin = new Thickness(5);
            SizeToContent = SizeToContent.WidthAndHeight;
            ResizeMode = ResizeMode.CanMinimize;
            //stack.HorizontalAlignment = HorizontalAlignment.Center;
            //stack.Orientation = Orientation.Horizontal;
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button();
                //btn.HorizontalAlignment = HorizontalAlignment.Center;
                btn.Name = ((char) ('A' + i)).ToString();
                //btn.Margin = new Thickness(5);
                btn.FontSize += random.Next(10);
                btn.Content = "Button " + btn.Name + " says 'Click Me'";
                //btn.Click += ButtonOnClick;
                stack.Children.Add(btn);
            }
            stack.AddHandler(Button.ClickEvent, new RoutedEventHandler(ButtonOnClick));
        }

        void ButtonOnClick(object sender, RoutedEventArgs args)
        {
            Button btn = args.Source as Button;
            MessageBox.Show("Button " + btn.Name + " has been clicked ", "Button click");

        }
    }
}
