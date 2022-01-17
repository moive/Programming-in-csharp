using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    //Escribir un método que acepte dos strings y devuelva el string con más caracteres. Si ambos tiene la misma cantidad de caracteres, devolver cualquiera de los dos.

    internal class Exercise3
    {
        public Exercise3()
        {
            init();
        }
        public void init()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter first string:");
                    string s1 = Console.ReadLine();
                    verifyInit(s1);
                    Console.WriteLine("Enter second string: ");
                    string s2 = Console.ReadLine();
                    verifyInit(s2);

                    countStrings(s1, s2);
                    Console.WriteLine("");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            
        }
        public void countStrings(string s1, string s2)
        {
            Action<string> spaceLine = Console.WriteLine;
            
            if (s1.Count()> s2.Count())
            {
                spaceLine("");
                Console.WriteLine(s1);
            }
            else if (s1.Count()< s2.Count())
            {
                spaceLine("");
                Console.WriteLine(s2);
            }
            else
            {
                spaceLine("");
                Console.WriteLine(s1);
            }
        }
        public void verifyInit(string s)
        {
            if (String.IsNullOrWhiteSpace(s))
            {
                throw new Exception($"The field cannot be empty");
            }
        }
    }
}
