using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2.Application
{
    public class HashSet
    {
        public HashSet()
        {

            HashSet<int> conj1 = new HashSet<int>();

            conj1.Add(5);
            conj1.Add(6);

            HashSet<int> conj2 = new HashSet<int>();
            conj2.Add(5);
            conj2.Add(8);

            HashSet<int> join_set1_set2 = new HashSet<int>(conj1);
            join_set1_set2.UnionWith(conj2);

            HashSet<int> intersection_set1_set2 = new HashSet<int>(conj1);
            intersection_set1_set2.IntersectWith(conj2);

            HashSet<int> simetric_set1_set2 = new HashSet<int>(conj1);
            simetric_set1_set2.SymmetricExceptWith(conj2);


            List<int> numbers = new List<int> { 1, 3, 4, 5, 5, 6, 7, 8, 2, 34, 2, 7, 9 };
            numbers = new HashSet<int>(numbers).ToList();

        }
    }
}
