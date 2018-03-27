using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows;

namespace Application任务
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup( object sender, StartupEventArgs e )
        {
            MainWindow win = new Application任务.MainWindow();
            if (e.Args.Length > 0)
            {
                string temp = e.Args[0];
                if (File.Exists(temp))
                {
                    win.loadfile(temp);
                }
            }
            win.Show();
        }
        private List<documents> document = new List<documents>();
        public List<documents> Documents
        {
            get { return document; }
            set { document = value; }
        }
    }
}
