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

namespace Binding数据
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        Student stu;
        public MainWindow()
        {
            InitializeComponent();
            stu = new Student();

            //binding
            Binding binding = new Binding();
            binding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            binding.Source = stu;
            binding.Path = new PropertyPath("Name");

            //使用绑定连接数据源和binding目标
            BindingOperations.SetBinding(this.tbName, TextBox.TextProperty, binding);
        }

        private void Button_Click( object sender, RoutedEventArgs e )
        {
            stu.Name += "Name";
        }
    }
}
