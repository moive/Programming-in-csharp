using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    //Escribir un método que acepte un datetime que represente la fecha de nacimiento de una persona y retornar su edad al día de hoy.
    internal class Exercise11
    {
        public Exercise11()
        {
            init();
        }

        public void init()
        {
            Console.WriteLine("Enter date of birth (dd/MM/yyyy)");
            while (true)
            {
                try
                {
                    string valueDate = Console.ReadLine();
                    DateTime date = DateTime.Parse(valueDate);
                    
                    DateTime today = DateTime.Today;
                    Console.WriteLine(today.Subtract(date).Days/365);

                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("The entered value is not a Datetime.");
                }
            }
        }
    }
}
