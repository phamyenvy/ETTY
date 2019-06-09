using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace LTUDQL2_QUAN_LY_CCVIDEO.Converter
{
    public class PosterUrlConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if (value.ToString() == "N/A")
                {
                    return "/Images/no-poster.png";
                }
                else
                    return value;
            }
            else
                return "/Images/no-poster.png"; 
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
