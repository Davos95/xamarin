using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace PaginasBinding.Converters
{
    public class ConvertidorMoneda : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if (value.ToString() == "")
                {
                    return 0;
                } else
                {
                    double moneda = double.Parse(value.ToString());
                    double dolar = moneda * 1.0831;
                    return dolar;
                }
            } else
            {
                return 0;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return 0;
        }
    }
}
