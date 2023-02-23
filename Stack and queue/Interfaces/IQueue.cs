using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_queue
{
    public interface IQueue<T>
    {
        void Enqueue(T item);
        T Dequeue();
    }
}
