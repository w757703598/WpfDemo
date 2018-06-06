using System;
using System.Collections.Generic;
using System.IO;
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

namespace Binding的数据转换
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

        private void btnLoad_Click( object sender, RoutedEventArgs e )
        {
            List<Plane> listPlane = new List<Plane>()
            {
                new Plane() {Category=Category.Bomber,Name="B-1" ,State=State.Unknown },
                new Plane() {Category=Category.Fighter,Name="BFS-1" ,State=State.Avaliable },
                new Plane() {Category=Category.Bomber,Name="BAS-1" ,State=State.Unknown },
                new Plane() {Category=Category.Fighter,Name="BA-1" ,State=State.Unknown },
                new Plane() {Category=Category.Fighter,Name="B-1" ,State=State.Unknown },
                new Plane() {Category=Category.Bomber,Name="D-1" ,State=State.Locked },
                new Plane() {Category=Category.Bomber,Name="F-1" ,State=State.Unknown },
                new Plane() {Category=Category.Fighter,Name="j-1" ,State=State.Avaliable },
                new Plane() {Category=Category.Fighter,Name="B-2" ,State=State.Unknown },
                
            };
            this.listBoxPlane.ItemsSource = listPlane;
        }

        private void btnSave_Click( object sender, RoutedEventArgs e )
        {
            StringBuilder SB = new StringBuilder();
            foreach (Plane item in listBoxPlane.Items)
            {
                SB.AppendLine(String.Format("Category={0},Name={1},State={2}", item.Category, item.Name, item.State));
            }
            File.WriteAllText(@"D:\Plane.txt", SB.ToString());
        }
    }
}
