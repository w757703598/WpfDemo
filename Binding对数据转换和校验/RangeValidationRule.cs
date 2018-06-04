using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace Binding对数据转换和校验
{
    public class RangeValidationRule:ValidationRule
    {
        //需要实现validate方法
        public override ValidationResult Validate( object value, CultureInfo cultureInfo )
        {
            double d = 0;
            if(double.TryParse(value.ToString(),out d))
            {
                if (d >= 0 && d <= 100)
                {
                    return new ValidationResult(true, null);
                }
            }
            return new ValidationResult(false, "Validation Failed");
        }
    }
}
