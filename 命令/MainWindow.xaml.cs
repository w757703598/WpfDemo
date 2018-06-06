using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace 命令
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeCommand();
        }

        //声明并定义命令
        private RoutedCommand clearCmd = new RoutedCommand("Clear", typeof(MainWindow));
        private void InitializeCommand()
        {
            //把命令赋值给命令源（发送者）并指定快捷键
            this.btn1.Command = this.clearCmd;
            this.clearCmd.InputGestures.Add(new KeyGesture(Key.C, ModifierKeys.Alt));

            //指定命令目标
            btn1.CommandTarget = tb1;

            CommandBinding cb = new CommandBinding();
            cb.Command = clearCmd;
            cb.CanExecute += Cb_CanExecute;
            cb.Executed += Cb_Executed;

            stackpanel1.CommandBindings.Add(cb);
        }
        /// <summary>
        /// 当命令被送到目标后，此方法被调用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cb_Executed( object sender, ExecutedRoutedEventArgs e )
        {
            tb1.Clear();
            e.Handled =true;
        }
        //当探测命令是否可以执行时，此方法被调用
        private void Cb_CanExecute( object sender, CanExecuteRoutedEventArgs e )
        {
            if (string.IsNullOrEmpty(this.tb1.Text))
            {
                e.CanExecute = false;
            }
            else
            {
                e.CanExecute = true;
            }
            //避免继续向上传递而降低性能
            e.Handled = true;
        }

        private void CommandBinding_CanExecute( object sender, CanExecuteRoutedEventArgs e )
        {
            if (string.IsNullOrEmpty(tb1.Text))
            {
                e.CanExecute = false;
            }
            else
            {
                e.CanExecute = true;
            }
        }

        private void CommandBinding_Executed( object sender, ExecutedRoutedEventArgs e )
        {
            string name = tb1.Text;
            if (e.Parameter.ToString() == "Teacher")
            {
                this.lsitbox1.Items.Add(string.Format("New Theacher:{0}", name));
            }
            if (e.Parameter.ToString() == "Student")
            {
                this.lsitbox1.Items.Add(string.Format("New Student:{0}", name));
            }
        }
    }
}
