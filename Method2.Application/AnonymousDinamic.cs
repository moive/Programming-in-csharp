using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2.Application
{
    public class AnonymousDinamic
    {
        public AnonymousDinamic()
        {
            var animal1 = new { animal = "dog", name = "Oso", life = 1 };
            var animal2 = new { animal = "cat", name = "Pinina", life = 7 };

            List<dynamic> animals = new List<dynamic>();

            animals.Add(animal1);
            animals.Add(animal2);

            foreach (dynamic a in animals)
            {
                Console.WriteLine("The {0} by name {1} has {2} life.", a.animal, a.name, a.life);
            }
        }
    }
}
