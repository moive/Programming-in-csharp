using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    //Escribir un método que acepte una lista de números y devuelva el producto de dichos números.
    internal class Exercise8
    {
        public Exercise8()
        {
            init();
        }

        public void init()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter number to calculate the factorial: ");
                    int num = int.Parse(Console.ReadLine());

                    if (num < 0)
                    {
                        throw new Exception();
                    }

                    factorial(num);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Enter only positive number.");
                }
            }
        }

        private void factorial(int num)
        {
            int fact = 1;
            for (int i = num; i != 0; i--)
            {
                fact *= i;
            }
            Console.WriteLine(fact);
        }
    }
}
