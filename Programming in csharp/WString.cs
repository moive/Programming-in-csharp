using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_in_csharp
{
    public class WString
    {
        public WString()
        {
            string name = "Moises";
            string sentence = "John and Joseph are friends";

            //Length
            Console.WriteLine($"Count name: {name.Length}");
            Console.WriteLine($"Count sentence: {sentence.Length}");

            //substring
            Console.WriteLine($"substring(3): {name.Substring(3)}");
            Console.WriteLine($"substring(9,4): {sentence.Substring(9,4)}");

            //startswith
            Console.WriteLine($"sentence StartsWith: {sentence.StartsWith("John")}");
            Console.WriteLine($"sentence StartsWith: {sentence.StartsWith("Joseph")}");

            //endswith
            Console.WriteLine($"sentence endswith: {sentence.EndsWith("friends")}");
            Console.WriteLine($"sentence endswith: {sentence.EndsWith("enemy")}");

            //contains
            Console.WriteLine($"contains: {sentence.Contains("Joseph")}");
            Console.WriteLine($"contains: {sentence.Contains("Peter")}");

            //indexof
            var indexJoseph = sentence.IndexOf("Joseph");
            var indexPeter = sentence.IndexOf("Peter");

            Console.WriteLine($"index Joseph: {indexJoseph}");
            Console.WriteLine($"index Peter: {indexPeter}");

            //operator +
            Console.WriteLine(name + ", " + sentence);

            //ToLower
            Console.WriteLine($"to lower: {sentence.ToLower()}");

            // ToUpper
            Console.WriteLine($"to upper: {sentence.ToUpper()}");

            //Trim
            string testTrim = "  Moises  ";
            Console.WriteLine($"trim: {testTrim.Trim()}");

            //Format
            string testFormat = "Congratulations {0} it's your {1}th birthday!, {0}";
            var resultFormat = string.Format(testFormat, name, 40);
            Console.WriteLine($"test format: {resultFormat}");

            //Replace
            string testReplace = "Congratulations @name it's your @ageth birthday!, @name";
            var resultReplace = testReplace.Replace("@name", name).Replace("@age","40");
            Console.WriteLine($"test replace: {resultReplace}");

            //interpolation
            int ageMoises = 40;
            string interpolationString = $"Congratulations {name} it's your {ageMoises}th birthday!, {name}";
            Console.WriteLine($"test interpolation: {interpolationString}");

            //IsNullOrWhiteSpace

            string stringSpace = "       ";
            string stringNull = null;

            Console.WriteLine($"IsNullOrWhiteSpace  space: {string.IsNullOrWhiteSpace(stringSpace)}");
            Console.WriteLine($"IsNullOrWhiteSpace null: {string.IsNullOrWhiteSpace(stringNull)}");
            Console.WriteLine($"IsNullOrWhiteSpace name: {string.IsNullOrWhiteSpace(name)}");
        }
    }
}
