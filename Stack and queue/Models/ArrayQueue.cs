using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_queue.Models
{
    public class ArrayQueue<T> : IQueue<T>
    {
        private T[] _items;
        private int _head = 0;
        private int _tail = 0;

        public ArrayQueue(int capacity)
        {
            _items = new T[capacity];
        }

        public void Enqueue(T item)
        {
            if (_tail == _items.Length)
            {
                throw new InvalidOperationException("Queue is full");
            }

            _items[_tail] = item;
            _tail++;
        }

        public T Dequeue()
        {
            if (_head == _tail)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            T item = _items[_head];
            _items[_head] = default(T);
            _head++;

            return item;
        }
    }
}
/*Advantages:
Random access: Arrays allow for constant-time access to any element by index, which is not possible in linked lists.
Memory efficiency: Arrays use a contiguous block of memory, so they are more memory-efficient than linked lists, which require extra memory for each node.
Disadvantages:
Fixed capacity: Arrays have a fixed capacity that is set when the array is created. If the number of elements exceeds this capacity, a new, larger array must be created and the existing elements must be copied over.
Costly resizing: Resizing an array can be a costly operation in terms of time and memory. If the array needs to be resized frequently, this can negatively impact performance.*/