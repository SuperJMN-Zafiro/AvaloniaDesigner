using System;
using System.Globalization;
using Avalonia;
using Avalonia.Data.Converters;
using Point = Designer.Domain.Models.Point;

namespace AvaloniaDesigner.Converters
{
    public class ModelPointConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Point p)
            {
                return new Avalonia.Point(p.X, p.Y);
            }

            return AvaloniaProperty.UnsetValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}