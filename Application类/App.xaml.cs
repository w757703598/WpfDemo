using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace Application类
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        private void Application_DispatcherUnhandledException( object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e )
        {

        }
        protected override void OnSessionEnding( SessionEndingCancelEventArgs e )
        {
            base.OnSessionEnding(e);
            e.Cancel = true;
            MessageBox.Show("无法关闭或注销");
        }
    }
}
