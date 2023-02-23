using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_queue.Models
{
    public class LinkedListQueue<T> : IQueue<T>
    {
        private LinkedList<T> list = new LinkedList<T>();

        public void Enqueue(T item)
        {
            list.AddLast(item);
        }

        public T Dequeue()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            T item = list.First.Value;
            list.RemoveFirst();
            return item;
        }
    }
}
