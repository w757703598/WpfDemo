using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 单实例应用程序
{
    class StartUp
    {
        [STAThread]
        public static void Main(string [] args )
        {
            //WPFApp app = new WPFApp();
            //app.Run();
            SingleInstanceApplicationWrapper singleapp = new SingleInstanceApplicationWrapper();
            singleapp.Run(args);
        }
    }
}
