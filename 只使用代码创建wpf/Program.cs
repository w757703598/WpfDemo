﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace 只使用代码创建wpf
{
    class Program:Application
    {
        [STAThread]
        static void Main()
        {
            Program app = new Program();
            app.MainWindow = new Window1();
            app.MainWindow.ShowDialog();
        }
    }
}
