using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    //Escribir un método que acepte una lista de strings y escriba en la consola el primer caracter de cada uno de los strings.

    internal class Exercise17
    {
        public Exercise17()
        {
            init();
        }

        public void init()
        {
            Console.WriteLine("Enter <0> for complete list");
            while (true)
            {
                try
                {
                    List<string> list = new List<string>();

                    while (true)
                    {
                        Console.Write("Enter string: ");
                        string n = Console.ReadLine();

                        if (n == "0")
                        {
                            break;
                        }

                        list.Add(n);
                    }
                    printedConsole(list);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("The entered value is not a string.");
                }
            }
        }

        private void printedConsole(List<string> list)
        {
            List<string> firstCharacter = new List<string>();
            Console.WriteLine("");
            Console.WriteLine("list entered:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
                firstCharacter.Add(item.Substring(item.Length-1));
            }
            
            Console.WriteLine("");
            Console.WriteLine("list last character:");



            foreach (var item in firstCharacter)
            {
                Console.WriteLine(item);
            }
        }
    }
}
