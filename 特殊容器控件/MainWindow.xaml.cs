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

namespace 特殊容器控件
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded( object sender, RoutedEventArgs e )
        {
            this.tb1.Text = "收拾收拾收拾收ssssssssssssssssssssssssssssssssssssssss是啊飞洒发收拾是是是收拾收拾收拾收拾收拾收拾收拾收拾收拾收拾收拾收拾收拾收拾收拾收拾收拾收拾是是是收拾收拾收拾收拾收拾收拾收是收拾收拾收拾收拾收拾收拾收拾收拾收拾收拾收拾收拾收收拾收拾收拾收拾收拾收拾收拾收拾收拾拾收拾收拾收拾收拾收拾收拾收拾收拾收拾收拾收拾收拾收收拾收拾是是是收拾收拾收拾收拾收拾收拾收拾收拾收拾收拾收拾收拾收拾收拾收拾收拾拾收拾收拾收拾收拾收拾收拾收拾收拾收";
        }

        private void button_Click( object sender, RoutedEventArgs e )
        {
            this.scrollview1.LineUp();
        }

        private void button1_Click( object sender, RoutedEventArgs e )
        {
            this.scrollview1.PageDown();
            this.scrollview1.ScrollToEnd();//一步到底
        }
    }
}
