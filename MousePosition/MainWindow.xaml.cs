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

namespace MousePosition
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

        private void rect_MouseMove( object sender, MouseEventArgs e )
        {
            Point pt = e.GetPosition(this);
            lbinfo.Text = "You Are at (" + pt.X +","+ pt.Y + ")" + "in window coorrdinates";
        }

        private void cmdcapture_Click( object sender, RoutedEventArgs e )
        {
            Mouse.Capture(this.rect);
            this.cmdcapture.Content = "Mosue is now Capture";
        }

        private void label1_MouseDown( object sender, MouseButtonEventArgs e )
        {
            Label lb = (Label)sender;
            DragDrop.DoDragDrop(lb, lb.Content, DragDropEffects.Copy);
        }

        private void label_Drop( object sender, DragEventArgs e )
        {
            ((Label)sender).Content = e.Data.GetData(DataFormats.Text);
        }
    }
}
