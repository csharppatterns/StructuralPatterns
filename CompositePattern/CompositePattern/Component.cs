using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    // The Component
    public class Component<T> : IComponent<T>
    {
        public T Name { get; set; }

        public Component(T name)
        {
            Name = name;
        }

        public void Add(IComponent<T> c)
        {
            Console.WriteLine("An item already exists");
        }

        public IComponent<T> Find(T p)
        {
            if (Name.Equals(p))
            {
                return this;
            }
            else
            {
                return null;
            }
        }
        public string Output(int depth = 0)
        {
            return new String(' ', depth) + Name.ToString() + "\n";
        }
    }
}
