using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2.Application
{
    public class FileGeneric
    {
        public FileGeneric()
        {
            MyCollection<decimal, string> myCollection = new MyCollection<decimal, string>();
            myCollection.Add(20);
            myCollection.Add("Moises");

            myCollection.GetAllItem();
        }
    }

    class MyCollection<T,M>
    {
        public List<T> MyList { get; set; }

        public MyCollection()
        {
            MyList = new List<T>();
        }

        public void Add(T item)
        {
            MyList.Add(item);
        }

        public void Add(M value)
        {
            //....
        }

        public void GetAllItem()
        {
            foreach (T item in MyList ) {
                Console.WriteLine(item);
            }
        }
    }
}
