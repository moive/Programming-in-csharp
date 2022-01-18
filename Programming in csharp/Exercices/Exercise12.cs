using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    //Escribir un fizzbuzz: Iterar los números del 1 al 100,
    //y cuando llegues a un número que sea multiple de 3(el 6 por ejemplo), escribir en la consola "Fizz",
    //cuando llegues a un número que sea múltiplo de 5(el 20 por ejemplo) escribir en la consola "Buzz",
    //cuando llegues a un número que sea múltiplo de 3 y 5(el 30 por ejemplo) escribir FizzBuzz en la consola

    internal class Exercise12
    {
        public Exercise12()
        {
            init();
        }

        public void init()
        {
            for (int i = 1; i <= 100; i++)
            {
                if(i%3==0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
