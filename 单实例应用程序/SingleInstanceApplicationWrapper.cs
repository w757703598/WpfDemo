using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic.ApplicationServices;

namespace 单实例应用程序
{
    class SingleInstanceApplicationWrapper:Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase
    {
        public SingleInstanceApplicationWrapper()
        {
            this.IsSingleInstance = true;

        }
        private WPFApp app;
        protected override bool OnStartup( StartupEventArgs eventArgs )
        {
            base.OnStartup(eventArgs);
            app = new WPFApp();
            app.Run();
            return false;
        }
        protected override void OnStartupNextInstance( StartupNextInstanceEventArgs eventArgs )
        {
            base.OnStartupNextInstance(eventArgs);
            app.showwindow();
        }
    }
}
