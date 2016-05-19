using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    // The Interface
    public interface IComponent<T>
    {
        T Name { get; set; }
        void Add(IComponent<T> c);
        IComponent<T> Find(T p);
        string Output(int depth = 0);
    }
}
