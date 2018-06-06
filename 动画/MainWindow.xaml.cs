using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace 动画
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
            DoubleAnimation daX = new DoubleAnimation();
            DoubleAnimation daY = new DoubleAnimation();

            //指定起点
            //daX.From = 0d;
            //daY.From = 0d;
            //指定终点
            Random r = new Random();
            daX.To = r.NextDouble() * 300;
            daY.To = r.NextDouble() * 300;

            daX.AccelerationRatio = 0.8;
            daY.DecelerationRatio = 0.8;

            daX.SpeedRatio = 0.5;
            daX.AutoReverse = true;

            //设置反弹
            BounceEase be = new BounceEase();
            be.Bounces = 3;
            be.Bounciness = 1;
            daX.EasingFunction = be;

            //指定时长
            Duration duration = new Duration(TimeSpan.FromMilliseconds(300));
            daX.Duration = duration;
            daY.Duration = duration;

            //动画的主体是TranslateTransform变形而非Button
            this.tt.BeginAnimation(TranslateTransform.XProperty, daX);
            tt.BeginAnimation(TranslateTransform.YProperty, daY);


        }

        private void Button_Click_1( object sender, RoutedEventArgs e )
        {
            DoubleAnimationUsingKeyFrames dakX = new DoubleAnimationUsingKeyFrames();
            DoubleAnimationUsingKeyFrames dakY = new DoubleAnimationUsingKeyFrames();

            //设置动画时长
            dakX.Duration = new Duration(TimeSpan.FromMilliseconds(2000));
            dakX.Duration = new Duration(TimeSpan.FromMilliseconds(2000));

            //创建、添加关键帧
            LinearDoubleKeyFrame x_kf_1 = new LinearDoubleKeyFrame();
            LinearDoubleKeyFrame x_kf_2 = new LinearDoubleKeyFrame();
            LinearDoubleKeyFrame x_kf_3 = new LinearDoubleKeyFrame();

            x_kf_1.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(300));
            x_kf_1.Value = 200;
            x_kf_2.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(600));
            x_kf_2.Value = 0;
            x_kf_3.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(900));
            x_kf_3.Value = 200;

            dakX.KeyFrames.Add(x_kf_1);
            dakX.KeyFrames.Add(x_kf_2);
            dakX.KeyFrames.Add(x_kf_3);

            LinearDoubleKeyFrame y_kf_1 = new LinearDoubleKeyFrame();
            LinearDoubleKeyFrame y_kf_2 = new LinearDoubleKeyFrame();
            LinearDoubleKeyFrame y_kf_3 = new LinearDoubleKeyFrame();

            y_kf_1.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(300));
            y_kf_1.Value = 200;
            y_kf_2.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(600));
            y_kf_2.Value = 0;
            y_kf_3.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(900));
            y_kf_3.Value = 200;

            dakY.KeyFrames.Add(y_kf_1);
            dakY.KeyFrames.Add(y_kf_2);
            dakY.KeyFrames.Add(y_kf_3);

            //执行动画
            t2.BeginAnimation(TranslateTransform.XProperty, dakX);
            t2.BeginAnimation(TranslateTransform.YProperty, dakY);
        }
    }
}
