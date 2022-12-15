using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2.Application
{
    public class ExpresionLambda
    {
        public ExpresionLambda()
        {
            Func<int, int> duplicate = x => x * 2;
            Func<int, int, int> multiply = (x, y) => x * y;

            Console.WriteLine(duplicate(25));
            Console.WriteLine(multiply(6,5));
        }
    }
}
