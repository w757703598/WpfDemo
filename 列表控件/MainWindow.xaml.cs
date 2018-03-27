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

namespace 列表控件
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

        private void listbox1_SelectionChanged( object sender, SelectionChangedEventArgs e )
        {
            if (listbox1.SelectedItem == null) return;
            this.txtselection.Text = "you choose item at position " + (listbox1.SelectedIndex+1)+"checkd item is "+listbox1.SelectedItem;
        }
    }
}
