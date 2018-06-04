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

namespace 使用集合对象作为列表控件的ItemSource
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //准备数据源
            List<Student> stulist = new List<Student>()
            {
                new Student() {Id=0,Name="Time",Age=29 },
                new Student() {Id=1,Name="Time1",Age=29 },
                new Student() {Id=2,Name="Time2",Age=29 },
                new Student() {Id=3,Name="Time3",Age=29 },
                new Student() {Id=4,Name="Time4",Age=29 },
                new Student() {Id=5,Name="Time5",Age=29 },
                new Student() {Id=6,Name="Time6",Age=29 },
                new Student() {Id=7,Name="Time7",Age=29 },
            };

            //为listbox设置binding
            this.listBoxStudent.ItemsSource = stulist;
            //this.listBoxStudent.DisplayMemberPath = "Name";

            Binding binding = new Binding("SelectedItem.Id") { Source = listBoxStudent };
            this.tbId.SetBinding(TextBox.TextProperty, binding);
        }
    }
}
