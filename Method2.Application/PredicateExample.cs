using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2.Application
{
    public class PredicateExample
    {
        public PredicateExample()
        {
            Predicate<Persona> predicate = IsOfAge;
            var p = new Persona()
            {
                Name = "Test",
                Age = 25
            };

            Console.WriteLine(predicate(p));
        }

        public bool IsOfAge(Persona person)
        {
            return person.Age >= 18;
        }
    }

    public class Persona
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
