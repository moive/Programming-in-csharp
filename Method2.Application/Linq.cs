using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2.Application
{
    public class Linq
    {
        public Linq()
        {
            LinqDemo();
        }

        public void LinqDemo()
        {
            List<int> numbers = new List<int>() { 3, 5, 7, 8, 2, -3, -100, 523, 6, 22 };
            var result = numbers.Where(x => x > 0 && x % 2 == 0).ToList();

        }
    }
}
