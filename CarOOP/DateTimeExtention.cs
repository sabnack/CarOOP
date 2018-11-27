using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public static class DateTimeExtention
    {
        public static int CarAge(this DateTime dateTime)
        {
            int.TryParse(DateTime.Now.Year.ToString(), out int yearNow);
            int.TryParse(dateTime.Year.ToString(), out int year);
            return yearNow - year;
        }
    }
}
