using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_in_csharp
{
    internal class ClassObject
    {
        //field
        private List<int> _components;

        //property
        public List<int> Components
        {
            get
            {
                return _components;
            }
        }

        //indexer
        public int this[int i]
        {
            get { return _components[i]; }
            set { _components[i] = value; }
        }

        public int Dimension { get { return _components.Count; } }

        //constructor
        public ClassObject(List<int> components)
        {
            _components = components;
        }

        public static ClassObject operator +(ClassObject v1, ClassObject v2)
        {
            return v1.Plus(v2);
        }

        public static ClassObject operator *(ClassObject v1, ClassObject v2)
        {
            throw new NotImplementedException();
        }

        public static ClassObject operator ++(ClassObject v1)
        {
            throw new NotImplementedException();
        }

        // method
        public ClassObject Plus(ClassObject v2)
        {

            if (Dimension != v2.Dimension)
            {
                throw new ApplicationException("The dimensions are not equals");
            }

            List<int> result = new List<int>();

            for (int i = 0; i < Dimension; i++)
            {
                result.Add(this[i] + v2[i]);
            }

            return new ClassObject(result);
        }
    }
}
