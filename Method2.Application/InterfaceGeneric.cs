using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2.Application
{
    interface IDoubleCollection<T, M>
    {
        void Add(T valueT, M valueM);
    }

    public class InterfaceGeneric
    {
        public InterfaceGeneric()
        {
            var myDoubleCollection = new MyDoubleCollection<string, int>(1);
            myDoubleCollection.Add("Moises", 7);
        }

        IDoubleCollection<T, M> FactoryMyDoubleCollection<T, M>(int discriminant)
        {
            if (discriminant == 1)
            {
                return new MyDoubleCollection<T, M>();
            }
            else if (discriminant == 2)
            {
                return new MyDoubleCollectionDictionary<T, M>();
            }
            throw new NotImplementedException();
        }
    }

    class MyDoubleCollection<T, M> : IDoubleCollection<T, M>
    {
        public List<T> MyListT { get; set; }
        public List<M> MyListM { get; set; }

        public MyDoubleCollection()
        {
            MyListT = new List<T>();
            MyListM = new List<M>();
        }

        public void Add(T valueT, M valueM)
        {
            MyListT.Add(valueT);
            MyListM.Add(valueM);
        }
    }

    class MyDoubleCollectionDictionary<T, M> : IDoubleCollection<T, M>
    {
        public Dictionary<T, M> Dictionary { get; set; }

        public void Add(T valueT, M valueM) { }
    }


}
