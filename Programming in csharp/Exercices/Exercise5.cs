using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    internal class Exercise5
    {
        //Utilizando un iterador escribir en pantalla los números de  al 100 de dos en dos.
        public Exercise5()
        {
            init();
        }
        public void init()
        {
            for (int i = 1; i <= 100; i=i+2)
            {
                Console.WriteLine($"{i}, {i+1}");
            }
        }
    }
}
