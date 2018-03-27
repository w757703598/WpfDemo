using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace 动态读取xaml内容
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
        public MainWindow(string xmalfie )
        {
            //设置窗体
            this.Width = this.Height = 500;
            this.Left = this.Top = 100;
            this.Title = "12";

            //从一个xaml文件中获取xaml内容
            DependencyObject rootElement;
            using (FileStream fs = new FileStream(xmalfie, FileMode.Open))
            {
                rootElement = (DependencyObject)XamlReader.Load(fs);
            }
            this.Content = rootElement;
        }
    }
}
