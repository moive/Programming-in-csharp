using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_in_csharp
{
    public class WDatetime
    {
        public void initializeDatetime()
        {
            DateTime date = new DateTime(2021, 12, 30);
            DateTime dateHours = new DateTime(2020, 11, 6, 9, 30, 45);

            Console.WriteLine(date.ToString());
            Console.WriteLine(date.ToString("MM/dd/yyyy"));
            Console.WriteLine(date.ToString("dd-MM-yy"));
            Console.WriteLine(dateHours.ToString("dd-MM-yyyy hh:mm:ss"));

            Console.WriteLine(date.AddDays(45).ToString());

            Console.WriteLine(dateHours.DayOfWeek);
            Console.WriteLine(dateHours.Date);
            // get the difference of days
            Console.WriteLine(date.Subtract(dateHours).Days);
        }
    }
}
