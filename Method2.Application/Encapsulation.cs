using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2.Application
{
    public class Encapsulation
    {
        private List<int> _list;

        public Encapsulation()
        {
            _list = new List<int>();
        }

        public List<int> List
        {
            get
            {
                return _list;
            }
            set
            {
                if(value != null)
                {

                _list = value;
                }
                else
                {
                    _list = new List<int>();
                }
            }
        }

        public void WriteList()
        {
            foreach (var item in _list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
