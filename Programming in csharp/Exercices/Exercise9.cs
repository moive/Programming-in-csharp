using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    //Escribir un método que acepte una lista de números y devuelva el producto de dichos números.
    internal class Exercise9
    {
        public Exercise9()
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
                            average(list);
                        }
                    }
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("The entered value is not a number.");
                }
            }
        }

        private void average(List<int> list)
        {
            double av = list.Count > 0 ? list.Average() : 0;
            Console.WriteLine($"The list average is: {av}");
        }
    }
}
