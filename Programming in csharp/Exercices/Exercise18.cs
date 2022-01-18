using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    internal class Exercise18
    {
        //Escribir un método que acepte un string y devuelve true si dicho string es un palíndromo, si no lo es devuelve false.
        //Un palíndromo es un texto que es igual al derecho ya al revés. Ejemplo: Ana es un palíndromo, pero pirata no lo es.

        public Exercise18()
        {
            init();
        }

        public void init()
        {
            Console.Write("Enter string: ");
            string s = Console.ReadLine();
            bool text = isPalindrome(s);
            Console.WriteLine($"The string is palindrome? : {text}");
        }

        private bool isPalindrome(string s)
        {
            var reverseText = string.Join("",s.ToLower().Reverse());
            return reverseText == s;
        }
    }
}
