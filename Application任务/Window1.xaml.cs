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
using System.Windows.Shapes;

namespace Application任务
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void button_Click( object sender, RoutedEventArgs e )
        {
            //MessageBox.Show("the main window is " + Application.Current.MainWindow.Title);
            //foreach (Window window in Application.Current.Windows)
            //{
            //    MessageBox.Show(window.Title);
            //}
            documents doc = new documents();
            doc.Owner = this;
            doc.Show();
            ((App)Application.Current).Documents.Add(doc);
        }

        private void button2_Click( object sender, RoutedEventArgs e )
        {
            foreach (documents doc in ((App)Application.Current).Documents)
            {
                doc.Content = "Refreshed at" + DateTime.Now.ToLongTimeString();
            }
        }
    }
}
