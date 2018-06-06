using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace DataTemplateTest
{
    //厂商名称转换为logo图片路径
    public class AutomakerToLogoPathConverter : IValueConverter
    {

        public object Convert( object value, Type targetType, object parameter, CultureInfo culture )
        {
            string uriStr = string.Format(@"/Resources/Logos/{0}.png",(string) value);
            return new BitmapImage(new Uri(uriStr, UriKind.Relative));
        }

        public object ConvertBack( object value, Type targetType, object parameter, CultureInfo culture )
        {
            throw new NotImplementedException();
        }
    }
    //汽车名称转换为图片路径
    public class NameToPhotoPathConverter : IValueConverter
    {
        public object Convert( object value, Type targetType, object parameter, CultureInfo culture )
        {
            string uriStr = string.Format(@"/Resources/Images/{0}.png",(string) value);
            return new BitmapImage(new Uri(uriStr, UriKind.Relative));
        }

        public object ConvertBack( object value, Type targetType, object parameter, CultureInfo culture )
        {
            throw new NotImplementedException();
        }
    }
}
