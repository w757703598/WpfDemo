using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Application类
{
    public  class Startup
    {
        [STAThread()]
        static void main()
        {
            Application app = new Application();
            MainWindow win = new MainWindow();
            app.Run(win);
        }
    }
}
