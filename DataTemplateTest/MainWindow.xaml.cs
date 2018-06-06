using DataTemplateTest;
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

namespace DataTemplateTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitialCarList();
        }
        //初始化LISTbOX
        private void InitialCarList()
        {
            List<Car> listCar = new List<Car>()
            {
                new Car() {Automaker="bwm" ,Name="wql" ,Year="1990",TopSpeed="350" },
                 new Car() {Automaker="bwm1" ,Name="wqlwq" ,Year="1998",TopSpeed="350" },
                  new Car() {Automaker="bwm2" ,Name="wqlwq" ,Year="1950",TopSpeed="350" },
                   new Car() {Automaker="bwm3" ,Name="wqwql" ,Year="2090",TopSpeed="500" }

            };
            foreach (Car  car in listCar)
            {
                CatListItemView view = new CatListItemView();
                view.Car = car;
                listBoxCars.Items.Add(view);
            }

        }
        private void listBoxCars_SelectionChanged( object sender, SelectionChangedEventArgs e )
        {
            CatListItemView view = e.AddedItems[0] as CatListItemView;
            if (view != null)
            {
                this.detailView.Car = view.Car;
            }
        }
    }
}
