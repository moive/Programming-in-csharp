using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2.Application
{
    public class ReadonlyConst
    {
        const double PI = 3.1415;
        readonly double PI_2 = RepositoryValues.PI;

        public ReadonlyConst()
        {
            Console.WriteLine("Value of const PI: {0}",PI);
            Console.WriteLine("Value of readonly PI_2 {0}:", PI_2);
        }
    }

    public static class RepositoryValues
    {
        public static double PI = 3.1415;
    }
}
