using System;
using System.Globalization;
using Avalonia.Data.Converters;
using Designer.Domain.Models;

namespace Designer.Converters
{
    public class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return default(Color);
            }

            var c = (Color)value;
            return Avalonia.Media.Color.FromArgb(c.A, c.R, c.G, c.B);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var c = (Avalonia.Media.Color)value;
            return new Color(c.A, c.R, c.G, c.B);
        }
    }
}