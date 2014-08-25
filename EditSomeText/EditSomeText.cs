using System;
using System.ComponentModel;
using System.IO;
using System.Net.Mime;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace EditSomeText
{
    class EditSomeText : Window
    {
        private static string strFileName = Path.Combine(
                                                         Environment.GetFolderPath(
                                                                                   Environment.SpecialFolder
                                                                                           .LocalApplicationData),
                "Petzold\\EditSomeText\\EditSomeText.txt");

        private TextBox txtBox;

        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new EditSomeText());
        }

        public EditSomeText()
        {
            Title = "Edit Some Text";

            txtBox = new TextBox();
            txtBox.AcceptsReturn = true;
            txtBox.TextWrapping = TextWrapping.Wrap;
            txtBox.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
            txtBox.KeyDown += TxtBoxOnKeyDown;
            Content = txtBox;

            try
            {
                txtBox.Text = File.ReadAllText(strFileName);
            }
            catch
            {
            }
        }

        #region Overrides of Window

        protected override void OnClosing(CancelEventArgs e)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(strFileName));
                File.WriteAllText(strFileName, txtBox.Text);
            }
            catch (Exception exc)
            {
                MessageBoxResult result =
                        MessageBox.Show("File could not be saved: " +
                                        exc.Message +
                                        "\nClose program anyway?", Title, MessageBoxButton.YesNo,
                                MessageBoxImage.Exclamation);
                e.Cancel = (result == MessageBoxResult.No);
            }
        }

        #endregion

        private void TxtBoxOnKeyDown(object sender, KeyEventArgs keyEventArgs)
        {
            if (keyEventArgs.Key == Key.F5)
            {
                txtBox.SelectedText = DateTime.Now.ToString();
                txtBox.CaretIndex = txtBox.SelectionStart + txtBox.SelectionLength;
            }
        }
    }
}