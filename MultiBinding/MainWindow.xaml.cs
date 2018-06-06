using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace MultiBinding
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetMultiBinding();
        }
        private void SetMultiBinding()
        {
            //准备基础binding
            Binding b1 = new Binding("Text") { Source = tb1 };
            Binding b2 = new Binding("Text") { Source = tb2 };
            Binding b3 = new Binding("Text") { Source = tb3 };
            Binding b4 = new Binding("Text") { Source = tb4 };
            //准备multiBinding
            System.Windows.Data.MultiBinding mb = new System.Windows.Data.MultiBinding();
            mb.Bindings.Add(b1);
            mb.Bindings.Add(b2);
            mb.Bindings.Add(b3);
            mb.Bindings.Add(b4);
            mb.Converter = new LogonMultiBindingConverter();

            //将button与multiBinding对象关联
            btn1.SetBinding(Button.IsEnabledProperty, mb);
        }
    }
    public class LogonMultiBindingConverter : IMultiValueConverter
    {
        public object Convert( object[] values, Type targetType, object parameter, CultureInfo culture )
        {
            if(!values.Cast<string>().Any(t=>string.IsNullOrEmpty(t))&&values[0].ToString()==values[1].ToString()
                && values[2].ToString() == values[3].ToString())
            {
                return true;
            }
            return false;
        }

        public object[] ConvertBack( object value, Type[] targetTypes, object parameter, CultureInfo culture )
        {
            throw new NotImplementedException();
        }
    }
}
