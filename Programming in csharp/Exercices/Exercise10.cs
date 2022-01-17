using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    //Escribir un método que acepte una lista de números y devuelva el más grande.
    internal class Exercise10
    {
        public Exercise10()
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
                        else
                        {
                            int nInt = int.Parse(n);
                            list.Add(nInt);
                        }
                    }
                    bigNumber(list);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("The entered value is not a number.");
                }
            }
        }

        private void bigNumber(List<int> list)
        {
            int max = list.Max();
            Console.WriteLine($"The biggest number in list is: {max}");
        }
    }
}
