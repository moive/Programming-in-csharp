using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_in_csharp
{
    internal class WNullable
    {
        public WNullable()
        {
            var person = new Person() { name = "Moises", age = 40 };
            person = null;

            Nullable<int> number = 50;
            number = null;

            DateTime? date = null;
            date = new DateTime(2022, 1, 15);

            if (number.HasValue) Console.WriteLine("The number has value");
            if (date.HasValue)
            {
                CalculateAge(date.Value);
                Console.WriteLine("The date has value");
            };
        }

        public static int CalculateAge(DateTime date)
        {
            return -1;
        }
    }

    public class Person
    {
        public string name;
        public int age;
    }
}
