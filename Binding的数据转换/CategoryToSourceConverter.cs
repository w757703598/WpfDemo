using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace Binding的数据转换
{
    public class CategoryToSourceConverter : IValueConverter
    {
        //将Category转换为URI
        public object Convert( object value, Type targetType, object parameter, CultureInfo culture )
        {
            Category C = (Category)value;
            switch (C)
            {
                case Category.Bomber:
                    return @"\Icons\Bomber.png";
                case Category.Fighter:
                    return @"\Icons\Fighter.png";
                default:
                    return null;
            }
        }
        //不会被调用
        public object ConvertBack( object value, Type targetType, object parameter, CultureInfo culture )
        {
            throw new NotImplementedException();
        }
    }
    public class StateToNullableBoolConverter : IValueConverter
    {
        //将state转换为bool
        public object Convert( object value, Type targetType, object parameter, CultureInfo culture )
        {
            State s = (State)value;
            switch (s)
            {
                case State.Avaliable:
                    return true;
                case State.Locked:
                    return false;
                case State.Unknown:
                default:
                    return null;
            }
        }
        //将bool转换为state
        public object ConvertBack( object value, Type targetType, object parameter, CultureInfo culture )
        {
            bool? nb = (bool?)value;
            switch (nb)
            {
                case true:
                    return State.Avaliable;
                case false:
                    return State.Locked;
                case null:
                default:
                    return State.Unknown;
            }
        }
    }
}
