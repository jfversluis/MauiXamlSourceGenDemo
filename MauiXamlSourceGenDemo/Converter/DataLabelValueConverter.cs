using System.Globalization;
using MauiXamlSourceGenDemo.Models;
using Microsoft.Maui.Controls;

namespace MauiXamlSourceGenDemo.Converter
{
    public class DataLabelValueConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is CategoryChartData categoryChartData)
            {
                switch (parameter?.ToString())
                {
                    case "Title":
                        return categoryChartData.Title;

                    case "Count":
                        return categoryChartData.Count;
                }
            }

            return value;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
