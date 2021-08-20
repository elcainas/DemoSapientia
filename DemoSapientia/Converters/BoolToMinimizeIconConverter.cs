using System;
using System.Globalization;
using Xamarin.Forms;

namespace DemoSapientia.Converters
{
    public class BoolToMinimizeIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool isVisible)
            {
                if (isVisible)
                    return "up.png";
                else
                    return "down.png";
            }
            else
            {
                return value;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
