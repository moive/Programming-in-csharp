using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2.Application
{
    public class Animal
    {
        public string? Name { get; set; }

        public virtual void MakeNoise()
        {
            Console.WriteLine("{0} make noise", Name);
        }
    }

    public class Cow : Animal
    {
        public Cow(string name)
        {
            Name = name;
        }

        public void Clean()
        {
            Console.WriteLine("The cow {0} was cleaned.", Name);
        }

        public override void MakeNoise() {
            Console.WriteLine("{0} say muuu", Name);
        }
    }

    public class Sheep : Animal
    {
        public Sheep(string name)
        {
            Name = name;
        }

        public void Shearing()
        {
            Console.WriteLine("The sheep {0} has been shorn", Name);
        }
    }

    public class Cat : Animal
    {
        public Cat(string name)
        {
            Name = name;
        }

        public override void MakeNoise()
        {
            Console.WriteLine("The cat {0} say miaauu!", Name);
        }
    }

    public class Pelican: Animal {
        public Pelican(string name)
        {
            Name = name;
        }
    }
}
