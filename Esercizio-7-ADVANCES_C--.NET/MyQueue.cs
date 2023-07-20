using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_7_ADVANCES_C__.NET
{
    public abstract class MyQueue<T> 
    {
        public Queue<T> queue = new Queue<T>();

        public abstract void Enqueue(T value);
        public abstract T Dequeue();
        public abstract T Peek();

    }
}
