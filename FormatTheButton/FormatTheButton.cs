using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace FormatTheButton
{
    public class FormatTheButton : Window
    {
        Run runButton;
        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new FormatTheButton());
        }

        public FormatTheButton()
        {
            Title = "Format The Button";

            Button btn = new Button();
            btn.HorizontalAlignment = HorizontalAlignment.Center;
            btn.VerticalAlignment = VerticalAlignment.Center;
            btn.MouseEnter += ButtonOnMouseEnter;
            btn.MouseLeave += ButtonOnMouseLeave;
            Content = btn;

            TextBlock txtBlk = new TextBlock();
            txtBlk.FontSize = 24;
            txtBlk.TextAlignment = TextAlignment.Center;
            btn.Content = txtBlk;

            txtBlk.Inlines.Add(new Italic(new Run("Click")));
            txtBlk.Inlines.Add(" the ");
            txtBlk.Inlines.Add(runButton = new Run("button"));
            txtBlk.Inlines.Add(new LineBreak());
            txtBlk.Inlines.Add("to launch the ");
            txtBlk.Inlines.Add(new Bold(new Run("rocket")));
        }

        void ButtonOnMouseEnter(object sender, MouseEventArgs args)
        {
            runButton.Foreground = Brushes.Red;
        }

        void ButtonOnMouseLeave(object sender, MouseEventArgs args)
        {
            runButton.Foreground = SystemColors.ControlTextBrush;
        }
    }
}
