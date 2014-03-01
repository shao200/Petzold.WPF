using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Petzold.RecordKeyStrokes
{
    public class RecordKeyStrokes : Window
    {
        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new RecordKeyStrokes());
        }

        public RecordKeyStrokes()
        {
            Title = "Record Key Strokes";
            Content = "";
        }

        protected override void OnTextInput(TextCompositionEventArgs args)
        {
            base.OnTextInput(args);
            string str = Content as string;
            if (args.Text == "\b")
            {
                if (!string.IsNullOrEmpty(str))
                    str = str.Substring(0, str.Length - 1);
            }
            else
            {
                str += args.Text;
            }
            Content = str;
        }
    }
}