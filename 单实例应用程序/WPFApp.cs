using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace 单实例应用程序
{
    class WPFApp:System.Windows.Application
    {

        protected override void OnStartup( StartupEventArgs e )
        {
            base.OnStartup(e);
            showwindow();
        }
        public void showwindow()
        {
            MainWindow win = new 单实例应用程序.MainWindow();
            win.Show();
        }
    }
}
