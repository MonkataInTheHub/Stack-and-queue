using Stack_and_queue.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_queue.Models
{
    public class LinkedListStack<T> : IStack<T>
    {
        private LinkedList<T> _list;

        public LinkedListStack()
        {
            _list = new LinkedList<T>();
        }

        public void Push(T item)
        {
            _list.AddLast(item);
        }

        public T Pop()
        {
            if (_list.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            T item = _list.Last.Value;
            _list.RemoveLast();
            return item;
        }
    }
}
