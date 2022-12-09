using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_in_csharp
{
    internal static class MethodExtension
    {
        public static double Power(this int value, int exponent) => Math.Pow(value, exponent);
        public static double Double(this int value) => value * 2;
    }
}
