using System;
using System.Globalization;
using Avalonia;
using Avalonia.Data.Converters;

namespace AvaloniaDesigner.Converters
{
    public class TypeNameToUriConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string typeName)
            {
                var assetName = typeName.Replace("Tool", "");
                return new Uri($"/Assets/Tools/{assetName}.png", UriKind.Relative);
            }

            return AvaloniaProperty.UnsetValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}