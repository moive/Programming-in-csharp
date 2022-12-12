using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2.Application
{
    public class RefOut
    {
        public RefOut()
        {
            var person = new Person() { Name = "Moises" };

            // Type reference
            Console.WriteLine("--Type of Reference--");
            Console.WriteLine("Before the change");
            Console.WriteLine(person.Name);
            EditPerson(person, "Robert");
            Console.WriteLine("After the change");
            Console.WriteLine(person.Name);

            Console.WriteLine("");

            // Type of value
            Console.WriteLine("--Type of value--");
            Console.WriteLine("Before the change");
            int age; // out is not necesary init value
            //Console.WriteLine(age);
            EditAge(out age, 14);
            Console.WriteLine("After the change");
            Console.WriteLine(age);
        }

        static void EditPerson(Person person, string newName) { 
            person.Name = newName;
        }

        static void EditAge(out int currentAge, int newAge)
        {
            currentAge = newAge;
        }
    }
}
