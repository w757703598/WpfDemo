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

namespace 文本控件
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

        private void textBox_SelectionChanged( object sender, RoutedEventArgs e )
        {

            if (this.textBox == null) return;

            //txtblock2.Text = "Selection from " + textBox.SelectionStart.ToString() + "to" + textBox.SelectionLength.ToString() + "is" + textBox.SelectedText;

        }

        private void button_Click( object sender, RoutedEventArgs e )
        {

        }

        private void Button_Click_1( object sender, RoutedEventArgs e )
        {
            txtblock2.Text="2141";
        }
    }
}
