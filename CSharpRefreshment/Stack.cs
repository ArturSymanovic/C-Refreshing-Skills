using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRefreshment
{
    public class Stack
    {
        private readonly List<object> _objects;

        public Stack()
        {
            _objects = new List<object>();
        }

        public void Push(object obj)
        {
            if (obj == null) throw new ArgumentNullException("Cannot push null object into a stack");
            _objects.Add(obj);
        }

        public object Pop()
        {
            if (_objects.Count == 0) throw new InvalidOperationException("Stack is empty.");
            var last = _objects.Last();
            _objects.RemoveAt(_objects.Count - 1);
            return last;
        }

        public void Clear()
        {
            _objects.Clear();
        }
    }
}
