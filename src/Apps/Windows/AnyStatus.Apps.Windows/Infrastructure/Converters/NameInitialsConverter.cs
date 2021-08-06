using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace AnyStatus.Apps.Windows.Infrastructure.Converters
{
    public class NameInitialsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is not string str || string.IsNullOrWhiteSpace(str))
            {
                return "#";
            }

            var nameSplit = str.Split(new[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);

            return nameSplit.Length switch
            {
                0 => string.Empty,
                1 => nameSplit.First()[..1].ToUpperInvariant(),
                _ => nameSplit.First()[..1].ToUpperInvariant() + nameSplit.Last()[..1].ToUpperInvariant()
            };
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}