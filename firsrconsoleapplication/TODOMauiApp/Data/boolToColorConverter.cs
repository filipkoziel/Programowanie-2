using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOMauiApp.Data
{
    public class boolToColorConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object Parameter, CultureInfo culture)
        {
            if (value == null || value is not bool)
                return Binding.DoNothing;

            if ((bool)value == true)
                return Color.FromRgb(255, 0, 0);

            return Color.FromRgb(0, 255, 0);
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
