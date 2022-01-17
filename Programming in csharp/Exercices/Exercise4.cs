using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    internal class Exercise4
    {
        //Escribir un método que acepte dos catetos y devuelve la hipotenusa (usar la clase Math para calcular la raíz cuadrada)
        public Exercise4()
        {
            init();
        }
        public void init()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter first number: ");
                    int n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second number: ");
                    int n2 = int.Parse(Console.ReadLine());
                    double h = getHypotenuse(n1,n2);
                    Console.WriteLine($"The value of hypotenuse is: {h}");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("The entered value is not a number");
                    Console.WriteLine("");
                }
            }
        }

        public double getHypotenuse(int n1, int n2)
        {
            double h = Math.Sqrt(Math.Pow(n1,2) + Math.Pow(n2,2));

            return h;
        }
    }
}
