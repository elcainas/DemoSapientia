using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace DemoSapientia.Converters
{
    public class MinimumValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var minimum = System.Convert.ToDouble(parameter, CultureInfo.InvariantCulture);
            var _value = System.Convert.ToDouble(value, CultureInfo.InvariantCulture);
            if (_value < minimum)
                return parameter;
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
