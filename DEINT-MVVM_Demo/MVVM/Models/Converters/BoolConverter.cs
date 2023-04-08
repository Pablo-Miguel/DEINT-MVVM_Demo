using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_MVVM_Demo.MVVM.Models.Converters
{
    public class BoolConverter : IValueConverter
    {
        public BoolConverter() {
            
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string respuesta = value.ToString();

            if(respuesta.Equals("Yes", StringComparison.OrdinalIgnoreCase)) return true;
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool respuesta = (bool) value;

            if (respuesta) return "Yes";
            return "No";
        }
    }
}
