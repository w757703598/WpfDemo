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

namespace 将元素绑定到一起
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

        private void button_Click( object sender, RoutedEventArgs e )
        {
            //this.slider1.Value = 30;
            this.textblock1.FontSize = 30;
        }

        private void Window_Loaded( object sender, RoutedEventArgs e )
        {
            Binding binding = new Binding();
            binding.Source = this.slider1;
            binding.Path = new PropertyPath("Value");
            binding.Mode = BindingMode.TwoWay;
            this.textblock1.SetBinding(TextBlock.FontSizeProperty, binding);
        }

        private void button1_Click( object sender, RoutedEventArgs e )
        {
            BindingOperations.ClearAllBindings(this.textblock1);
        }
    }
}
