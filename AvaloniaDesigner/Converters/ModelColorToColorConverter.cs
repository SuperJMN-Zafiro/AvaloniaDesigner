using System;
using System.Globalization;
using Avalonia;
using Avalonia.Data.Converters;
using Avalonia.Media;
using ModelColor = Designer.Domain.Models.Color;

namespace Designer.Converters
{
    public class ModelColorToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is ModelColor p)
            {
                return new Color(p.A, p.R, p.G, p.B);
            }

            return AvaloniaProperty.UnsetValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Color c)
            {
                return ModelColor.FromArgb(c.A, c.R, c.G, c.B);
            }

            return null;
        }
    }
}