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

namespace Binding对数据转换和校验
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Binding binding = new Binding("Value") { Source = slider1 };
            binding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            RangeValidationRule rvr = new RangeValidationRule();
            rvr.ValidatesOnTargetUpdated = true;
            binding.ValidationRules.Add(rvr);
            binding.NotifyOnValidationError = true;
            tbInput.SetBinding(TextBox.TextProperty, binding);

            tbInput.AddHandler(Validation.ErrorEvent, new RoutedEventHandler(ValidationErrorHandler));
        }

        private void ValidationErrorHandler( object sender, RoutedEventArgs e )
        {
            if (Validation.GetErrors(tbInput).Count > 0)
            {
                tbError.Text = Validation.GetErrors(tbInput)[0].ErrorContent.ToString();
            }
            else
            {
                tbError.Text = "";
            }
        }
    }
}
