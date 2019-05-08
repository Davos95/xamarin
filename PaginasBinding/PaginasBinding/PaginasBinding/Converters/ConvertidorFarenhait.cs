using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace PaginasBinding.Converters
{
    public class ConvertidorFarenhait : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //VALUES ES EL DATO ASOCIADO AL BINDING (cajacelsius)
            if(value != null)
            {
                if(value.ToString() == "")
                {
                    return 0;
                }
                else
                {
                    int celsius = int.Parse(value.ToString());
                    double gradosfarenhait = 0;
                    double ope1 = celsius * 2;
                    double ope2 = ope1 * 1 / 10;
                    double ope3 = ope1 - ope2;
                    gradosfarenhait = ope3 + 32;
                    return gradosfarenhait;

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
