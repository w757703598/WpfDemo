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
using System.Xml;

namespace 试用Xml数据作为Binding的源
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

        private void Button_Click( object sender, RoutedEventArgs e )
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"..\..\Student.xml");

            XmlDataProvider xdp = new XmlDataProvider();
            xdp.Document = doc;

            //试用xmlpath选择要暴漏的数据
            xdp.XPath = @"/StudentList/Student";
            this.listViewStudents.DataContext = xdp;
            this.listViewStudents.SetBinding(ListView.ItemsSourceProperty, new Binding());
        }
    }
}
