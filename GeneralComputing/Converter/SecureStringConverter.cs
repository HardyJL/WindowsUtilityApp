using GeneralComputing.Functions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace GeneralComputing.Converter
{
    [ValueConversion(typeof(SecureString), typeof(String))]
    public class SecureStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            SecureString secureString = (SecureString)value;
            return secureString.SecureStringToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return new NetworkCredential("", (string)value).SecurePassword;
        }
    }
}
