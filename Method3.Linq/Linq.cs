using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method3.Linq
{
    public class Linq
    {
        public Linq()
        {
            LinqDemo();
        }

        public void LinqDemo()
        {
            List<int> numbers = new List<int>() { 3, 5, 7, 8, 2, -3, -100, 523, 6, 22 };
            //numbers.Reverse(1,8); //reverse 5, ..., 6

            var elementFirst = numbers.FirstOrDefault(x => x % 2 == 0);
            //var result = numbers.Where((x, index) => index % 2 == 0).ToList();
            var result = numbers.Where(x => x > 0).OrderByDescending(x => x).ToList();

            var getTakeSkip = numbers.Skip(1).Take(3).ToList();

            var takeWhile = numbers.TakeWhile(x => x < 6).ToList();
            var skipWhite = numbers.SkipWhile(x => x < 6).ToList();

            var areEven = numbers.All(x=> x% 2 == 0);
            var IsThereAnyOddNumber = numbers.Any(x => x % 2 == 0);

            List<Person> persons = new List<Person>() {
                new Person(){Name = "María", Age = 99, Salary=5},
                new Person(){Name = "Claudia", Age = 35, Salary=7},
                new Person(){Name = "Patricia", Age = 12, Salary=1},
                new Person(){Name = "Mateo", Age = 17, Salary=10},
                new Person(){Name = "Ana", Age = 22, Salary=5},
            };

            var personUnderAge = persons.Where(x => x.Age < 18)
                .OrderByDescending(x => x.Age)
                .Select(x => new
                {
                    Name = x.Name,
                    Age = x.Age,
                })
                .FirstOrDefault();

            var listPersons = persons.OrderBy(x => x.Salary).ThenBy(x => x.Name).ToList();

            var totalSalary = persons.Sum(x => x.Salary);

            var myObject = new
            {
                TotalSalary = totalSalary,
                Count = persons.Count()
            };

            var salaryMin = persons.Min(x => x.Salary);
            var salaryMax = persons.Max(x => x.Salary);
            var averageAge = persons.Average(x => x.Age);


            var groupBy = numbers.GroupBy(x => Math.Abs(x % 2));

            var productAggregate =numbers.Aggregate((acc, elem)=>acc * elem);

            foreach (var item in groupBy)
            {
                Console.WriteLine("Numbers whose residues are: " + item.Key);
                foreach (var num in item)
                {
                    Console.WriteLine(num);
                }
                Console.WriteLine("");
            }

            var groupByPerson = persons.GroupBy(x =>
            {
                if (x.Age <= 20)
                {
                    return "Less than 20";
                }
                else if (x.Age >= 21 && x.Age <= 40)
                {
                    return "Between 21 and 40";
                }
                else
                {
                    return "Greater than 41";
                }
            });

            foreach (var groupPerson in groupByPerson)
            {
                Console.WriteLine("Group by: " + groupPerson.Key + " --- amount: " + groupPerson.Count());
                foreach (var person in groupPerson)
                {
                    Console.WriteLine(person.Name);
                }
                Console.WriteLine("");
            }
        }
    }

    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
    }
}
