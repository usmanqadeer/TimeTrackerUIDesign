using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XFUITimeTrackerDesign.Helpers
{
    public class ValueProgressBarConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return (double)value / 60;
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return new NotImplementedException();
        }
    }
}
