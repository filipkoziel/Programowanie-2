using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF04_01_2024_06.Resources.Converters
{
    class StringToBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            
            return ((int)value).ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null
                || value is not string
                || !int.TryParse((string)value, out int num)
                || num > 100
                || num < 0)
                return Binding.DoNothing;

            return num;
        }
    }
}
