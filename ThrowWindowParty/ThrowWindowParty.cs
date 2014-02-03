﻿using System;
using System.Windows;
using System.Windows.Input;

namespace Petzold.ThrowWindowParty
{
    class ThrowWindowParty : Application
    {
        [STAThread]
        public static void Main()
        {
            ThrowWindowParty app = new ThrowWindowParty();
            app.Run();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            Window winMain = new Window();
            winMain.Title = "Main Window";
            winMain.MouseDown += WindowOnMouseDown;
            winMain.Show();

            for (int i = 0; i < 2; i++)
            {
                Window win = new Window();
                win.Title = "Extra window No. " + (i + 1);
                win.ShowInTaskbar = false;
                win.Owner = winMain;
                win.Show();
            }
        }

        void WindowOnMouseDown(object sender, MouseButtonEventArgs args)
        {
            Window win = new Window();
            win.Title = "Modal Dialog Box";
            win.ShowDialog();
        }
    }

}