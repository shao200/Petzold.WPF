using System;
using System.Reflection;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Petzold.FlipThroughTheBrushes
{
    public class FlipThroughTheBrushes : Window
    {
        private int index = 0;
        private PropertyInfo[] props;

        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new FlipThroughTheBrushes());
        }

        public FlipThroughTheBrushes()
        {
            props = typeof (Brushes).GetProperties(BindingFlags.Public | BindingFlags.Static);
            
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.Key == Key.Down || e.Key == Key.Up)
            {
                index += e.Key == Key.Up ? 1 : props.Length - 1;
                index %= props.Length;
                SetTitleAndBackground();
            }
            base.OnKeyDown(e);
        }

        void SetTitleAndBackground()
        {
            Title = "Flip through the brhushes - " + props[index].Name;
            Background = (Brush) props[index].GetValue(null, null);
        }
    }
}