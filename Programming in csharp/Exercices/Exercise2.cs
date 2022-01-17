using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    //Escribir un método que acepte un número y devuelva True si el npumero es par, o false si es impar.
    internal class Exercise2
    {
        public Exercise2()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter number: ");
                    int n = int.Parse(Console.ReadLine());
                    isPair(n);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("The value entered is not a number");
                    Console.WriteLine("");
                    Console.WriteLine(ex);
                    Console.WriteLine("");
                }
            }
        }

        public void isPair(int n)
        {
            if (n%2==0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
