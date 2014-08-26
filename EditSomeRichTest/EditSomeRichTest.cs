using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace EditSomeRichTest
{
    public class EditSomeRichTest : Window
    {
        private RichTextBox txtBox;
        private string strFilter = "Document files (*.xaml)|*.xaml|All files (*.*)|*.*";

        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new EditSomeRichTest());
        }

        public EditSomeRichTest()
        {
            Title = "Edit Some Rich Text";
            txtBox = new RichTextBox();
            txtBox.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
            Content = txtBox;
            txtBox.Focus();
        }

        protected override void OnPreviewTextInput(TextCompositionEventArgs args)
        {
            if (args.ControlText.Length > 0 && args.ControlText[0] == '\x0F')
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.CheckFileExists = true;
                dlg.Filter = strFilter;

                if ((bool) dlg.ShowDialog(this))
                {
                    FlowDocument flow = txtBox.Document;
                    TextRange range = new TextRange(flow.ContentStart, flow.ContentEnd);
                    Stream strm = null;

                    try
                    {
                        strm = new FileStream(dlg.FileName, FileMode.Open);
                        range.Load(strm, DataFormats.Xaml);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message, Title);
                    }
                    finally
                    {
                        if (strm != null)
                            strm.Close();
                    }
                }
                args.Handled = true;
            }
            if (args.ControlText.Length > 0 && args.ControlText[0] == '\x13')
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = strFilter;

                if ((bool) dlg.ShowDialog(this))
                {
                    FlowDocument flow = txtBox.Document;
                    TextRange range = new TextRange(flow.ContentStart, flow.ContentEnd);

                    Stream strm = null;

                    try
                    {
                        strm = new FileStream(dlg.FileName, FileMode.Create);
                        range.Save(strm, DataFormats.Xaml);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message, Title);
                    }
                    finally
                    {
                        if (strm != null)
                            strm.Close();
                    }
                }
                args.Handled = true;
            }
            base.OnPreviewTextInput(args);
        }
    }
}