using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using 动态读取xaml内容;

namespace 动态读取xaml内容
{
    class Programs:Application
    {
        [STAThread()]
        static void Main()
        {
            Programs programs = new Programs();
            programs.MainWindow = new MainWindow("MainWindow.xaml");
            programs.MainWindow.ShowDialog();
        }
    }
}
