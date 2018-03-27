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

namespace 资源字典
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

        private void button2_Click( object sender, RoutedEventArgs e )
        {

        }

        private void Window_Loaded( object sender, RoutedEventArgs e )
        {
            ResourceDictionary rd = new ResourceDictionary();
            rd.Source = new Uri("ResourceLibrary:component/Dictionary.xaml", UriKind.Relative);//相对的uri
            button2.Background = (Brush)rd["TitleBrush1"];
        }
    }
}
