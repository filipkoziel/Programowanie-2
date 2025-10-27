using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF04_01_2024_06.Resources.Converters
{
    internal class IntToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null
                || value is not int)
                return null;

            int number = (int)value;

            return number switch
            {
                1 => "k1.jpg",
                2 => "k2.jpg",
                3 => "k3.jpg",
                4 => "k4.jpg",
                5 => "k5.jpg",
                6 => "k6.jpg",
                _ => "question.jpg",
            };
        }
            
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
