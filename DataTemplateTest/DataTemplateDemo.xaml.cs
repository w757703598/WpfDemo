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

namespace DataTemplateTest
{
    /// <summary>
    /// DataTemplateDemo.xaml 的交互逻辑
    /// </summary>
    public partial class DataTemplateDemo : Window
    {
        public DataTemplateDemo()
        {
            InitializeComponent();
            InitialCarList();
        }
        private void InitialCarList()
        {
            
            List<Car> listCar = new List<Car>()
            {
                new Car() {Automaker="bwm" ,Name="wql" ,Year="1990",TopSpeed="350" },
                 new Car() {Automaker="bwm1" ,Name="wqlwq" ,Year="1998",TopSpeed="350" },
                  new Car() {Automaker="bwm2" ,Name="wqlwq" ,Year="1950",TopSpeed="350" },
                   new Car() {Automaker="bwm3" ,Name="wqwql" ,Year="2090",TopSpeed="500" }

            };
            listBoxCars.ItemsSource = listCar;
            
        }
    }
}
