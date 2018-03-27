using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace 只使用代码创建wpf
{
    class Window1:Window
    {
        private Button button1;
        public Window1()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            //配置窗体大小
            this.Width = 285;
            this.Height = 250;
            this.Left = this.Top = 100;
            this.Title = "CodeOnlyWindow";

            //创建面板对象
            //容器
            DockPanel panel = new DockPanel();
            button1 = new Button();
            button1.Content = "please click me !";
            button1.Margin = new Thickness(30);

            button1.Click += Button1_Click;

            IAddChild container = panel;
            container.AddChild(button1);
            container = this;
            container.AddChild(panel);

        }

        private void Button1_Click( object sender, RoutedEventArgs e )
        {
            button1.Content = "Thank you ";
        }
    }
}
