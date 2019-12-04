using System;
using System.Globalization;
using System.Linq;
using Avalonia.Data.Converters;

namespace AvaloniaDesigner.Converters
{
    public class ShadowConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var array = (object[])value;

            if (array.Any(o => o == null))
            {
                return 0D;
            }

            var angle = (double)array[0];
            var distance = (double)array[1];

            var s = parameter as string;
            var rad = 2 * Math.PI * angle;
            if (s == "Y")
            {
                return Math.Sin(rad) * distance * 2;
            }
            else
            {
                return Math.Cos(rad) * distance * 2;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}