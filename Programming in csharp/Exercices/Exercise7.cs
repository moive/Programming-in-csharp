using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    //Escribir un método que acepte una lista de números y devuelva el producto de dichos números.
    internal class Exercise7
    {
        public Exercise7()
        {
            init();
        }

        public void init()
        {
            Console.WriteLine("Enter <c> for complete list");
            while (true)
            {
                try
                {
                    List<int> list = new List<int>();

                    while (true)
                    {
                        Console.Write("Enter number: ");
                        string n = Console.ReadLine();

                        if (n == "c")
                        {
                            break;
                        }
                        int nInt = int.Parse(n);
                        list.Add(nInt);
                    }
                    printedConsole(list);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("The entered value is not a number.");
                }
            }
        }

        public void printedConsole(List<int> list)
        {
            if (list.Count() != 0)
            {
                Console.WriteLine($"The multiplication value is: {listMultiplication(list)}");
            }
            else
            {
                Console.WriteLine("No multiplication numbers.");
            }
        }

        public int listMultiplication(List<int> numbers)
        {
            int n = 1;

            foreach (var item in numbers)
            {
                n *= item;
            }
            return n;
        }
    }
}
