using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2.Application
{
    public class Delegate
    {
        public delegate string FromIntegerToString(int value);

        public Delegate()
        {
            var fromIntegerToString = new FromIntegerToString(FunctionReturnToString);
            var fromIntegerToStringPlusOne = new FromIntegerToString(FunctionReturnToStringPlus1);

            Console.WriteLine(fromIntegerToString(10));
            Console.WriteLine(fromIntegerToStringPlusOne(10));

            Func<int, string> delegateFunc = FunctionReturnToStringPlus1;
            var result = delegateFunc(15);
            Console.WriteLine(result);

            Action<int, string> delegateAction = Example;
        }

        public string FunctionReturnToString(int value) => value.ToString();

        public string FunctionReturnToStringPlus1(int value) => (value + 1).ToString();

        public void Example(int a, string b) { }
    }
}
