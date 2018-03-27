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

namespace 控件类
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
            Cursor = Cursors.ScrollNE;
            //this.btn1.Background = new SolidColorBrush(Color.FromRgb(255,100,30));
            //this.btn1.Foreground = System.Windows.SystemColors.ControlDarkBrush; 
            foreach (FontFamily item in Fonts.SystemFontFamilies)
            {
                listView.Items.Add(item.Source);
            }
        }
    }
}
