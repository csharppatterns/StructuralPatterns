using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    // The Composite
    class Composite<T> : IComponent<T>
    {
        public T Name { get; set; }
        List<IComponent<T>> list;

        public Composite(T name)
        {
            Name = name;
            list = new List<IComponent<T>>();
        }

        public void Add(IComponent<T> c)
        {
            list.Add(c);
        }

        // Recursively looks for an item
        public IComponent<T> Find(T p)
        {
            if (Name.Equals(p)) {
                return this;
            }
            IComponent<T> found = null;
            foreach (IComponent<T> component in list)
            {
                found = component.Find(p);
                if (found != null)
                {
                    break;
                }
            }
            return found;
        }

        // Returns items in a format indicating their level in the composite structure
        public string Output(int depth = 0)
        {
            StringBuilder sb = new StringBuilder(new String(' ', depth));
            sb.Append(Name.ToString() + " (" + list.Count() + ")\n");
            foreach (IComponent<T> component in list)
            {
                sb.Append(component.Output(depth + 2));
            }
            return sb.ToString();
        }
    }
}
