﻿using System;
using System.Windows;
using System.Windows.Input;

namespace Petzold.InheritTheWin
{
    class InheritTheWin : Window
    {
        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new InheritTheWin());
        }

        public InheritTheWin()
        {
            Title = "Inherit The Win";
        }
    }
}