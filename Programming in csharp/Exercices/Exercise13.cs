using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    //Escribir un método que acepte una lista con números y devuelva dicha lista en orden invertido.

    internal class Exercise13
    {
        public Exercise13()
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

        private void printedConsole(List<int> list)
        {
            Console.WriteLine("list");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            list.Reverse();
            Console.WriteLine("");
            Console.WriteLine("list reverse");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
