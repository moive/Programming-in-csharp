using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2.Application
{
    public class Dictionary
    {
        public Dictionary()
        {
            Dictionary<string, int> nameAge = new Dictionary<string, int>();
            nameAge.Add("Moises", 40);
            nameAge.Add("Jorge", 45);
            nameAge.Add("Maria", 45);

            Console.WriteLine("Moises is {0} year old", nameAge["Moises"]);

            if (nameAge.ContainsKey("itemNotExists"))
            {
                Console.WriteLine(nameAge["itemNotExists"]);
            }

            nameAge.Remove("Maria");

            foreach (var keys in nameAge.Keys)
            {
                Console.WriteLine(keys);
            }

        }
    }
}
