using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_in_csharp
{
    internal class Params
    {
        public double CalculateAverage(params int[] numbers) {
            double plus = 0.0;
            foreach (var number in numbers)
            {
                plus = plus + number;
            }

            return plus / numbers.Count();
        }
    }
}
