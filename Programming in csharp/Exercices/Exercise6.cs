using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    //Escribir un método que acepte un double que represente un número en grados Celcius y lo transforme en grados Fahrenheit.
    internal class Exercise6
    {
        public Exercise6()
        {
            init();
        }

        public void init()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter number to be convert to degrees farenheit");
                    double num = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{num} in degradess farenheit is: {convertFahrenheit(num)} °F");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("The entered value is not a number");
                }
            }
        }

        public double convertFahrenheit(double c) => (c * 1.8) + 32;
    }
}
