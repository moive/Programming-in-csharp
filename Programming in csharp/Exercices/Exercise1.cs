using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    class Exercise1
    {
        //1. Permitir al usuario escribir dos números y mostrar en pantalla cuál de los 2 es el mas grande. Si son iguales, mostrar cualquiera.
        public Exercise1()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("ENTER FIRST NUMBER: ");
                    int n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("ENTER SECOND NUMBER: ");
                    int n2 = int.Parse(Console.ReadLine());

                    compareNumber(n1, n2);

                    break;
                }
                catch (Exception Ex)
                {

                    Console.WriteLine("The value entered is not a number");
                    Console.WriteLine("");
                    //Console.WriteLine(Ex);
                }
            }
            
        }

        public void compareNumber(int a, int b)
        {
            if (a > b) Console.WriteLine($"The number major is: {a}");
            else if (b > a) Console.WriteLine($"The number major is: {b}");
            else Console.WriteLine($"The number is equal: {a}");

        }
    }
}
