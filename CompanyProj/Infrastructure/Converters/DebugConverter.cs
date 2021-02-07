using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace CompanyProj.Infrastructure.Converters
{
    public class DebugConverter : IValueConverter
    {
        public object Convert(object value, Type t, object p, CultureInfo c)
        {
            Debugger.Break();
            return value;
        }

        public object ConvertBack(object value, Type t, object p, CultureInfo c)
        {
            Debugger.Break();
            return value;
        }
    }
}
