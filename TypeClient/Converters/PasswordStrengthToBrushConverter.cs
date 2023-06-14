using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace TypeClient.Converters
{
    public class PasswordStrengthToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var passwordStrength = (int)value;
            var converter = new BrushConverter();
            if (passwordStrength == 0)
            {
                return Brushes.Gray;
            }
            if (passwordStrength == 20)
            {
                return (Brush)converter.ConvertFromString("#E02700");
            }
            else if (passwordStrength == 40)
            {
                return (Brush)converter.ConvertFromString("#C87800");
            }
            else if (passwordStrength == 60)
            {
                return (Brush)converter.ConvertFromString("#C0CB00");
            }
            else if (passwordStrength == 80)
            {
                return (Brush)converter.ConvertFromString("#BDD600");
            }
            else
            {
                return (Brush)converter.ConvertFromString("#0FC100");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
