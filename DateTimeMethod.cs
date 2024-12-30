using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class DateTimeMethod
    {
        public void DateTimeFunction()
        {
            DateTime d;
            d= DateTime.Now;
            Console.WriteLine(d);
            Console.WriteLine($" Day -> {d.Day}");
            Console.WriteLine($" Month -> {d.Month}");
            Console.WriteLine($" Year -> {d.Year}");

            Console.WriteLine($" Hour -> {d.Hour}");
            Console.WriteLine($" Minute -> {d.Minute}");
            Console.WriteLine($" Second -> {d.Second}");
            Console.WriteLine($" Millisecond -> {d.Millisecond}");

            Console.WriteLine($"ShortTime -> {d.ToShortTimeString()}");
            Console.WriteLine($"LongTime -> {d.ToLongTimeString()}");
            Console.WriteLine($"ShortDate -> {d.ToShortDateString()}");
            Console.WriteLine($"LongDate -> {d.ToLongDateString()}");

            Console.WriteLine($"Day of the week : {d.DayOfWeek.ToString()}");
            Console.WriteLine($"Day of the year : {d.DayOfYear}");
            String d1 = DateTime.Today.ToString("dd/MM/yyyy",CultureInfo.InvariantCulture);
            Console.WriteLine($" New date format : {d1}");
        }
    }
}
