using Stack_and_queue.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_queue.Models
{
    public class ArrayStack<T> : IStack<T>
    {
        private T[] _items;
        private int _count;


        public ArrayStack(int capacity)
        {
            _items = new T[capacity];
            _count = 0;
        }

        public void Push(T item)
        {
            if (_count == _items.Length)
            {
                throw new InvalidOperationException("Stack is full");
            }
            _items[_count++] = item;
        }

        public T Pop()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return _items[--_count];
        }
    }
}
