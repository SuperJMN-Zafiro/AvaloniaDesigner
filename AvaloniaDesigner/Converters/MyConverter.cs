using System;
using Avalonia.Media;
using Color = Designer.Domain.Models.Color;
using CornerRadius = Avalonia.CornerRadius;

namespace Designer.Converters
{
    public static class MyConverter
    {
        public static double PolarToCartesianX(double angle, double distance)
        {
            var rad = Math.PI * angle / 180;
            return Math.Cos(rad) * distance;
        }

        public static double PolarToCartesianY(double angle, double distance)
        {
            var rad = 2 * Math.PI * angle / 180;
            return Math.Sin(rad) * distance;
        }

        public static bool DistanceToVisibility(double distance)
        {
            if (Math.Abs(distance) < 1)
            {
                return false;
            }

            return true;
        }
        
        public static SolidColorBrush TintColor(Color color, double tint)
        {           
            return new SolidColorBrush(Avalonia.Media.Color.FromArgb(
                color.A,
                ApplyTint(color.R, tint),
                ApplyTint(color.G, tint),
                ApplyTint(color.B, tint)
            ));
        }

        public static byte ApplyTint(byte component, double tint)
        {
            var resultingValue = (1.0 - tint) * 255 + tint * component;
            return (byte)resultingValue;
        }

        public static CornerRadius DoubleToCornerRadius(double v)
        {
            return new CornerRadius(v);
        }

        public static double Negate(double n)
        {
            return -n;
        }
    }
}