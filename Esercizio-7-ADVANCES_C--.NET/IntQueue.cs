using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_7_ADVANCES_C__.NET
{
    public class IntQueue<T> : MyQueue<T>
    {
        public override T Dequeue()
        {
            if(queue== null)
            throw new NotImplementedException();
            return queue.Dequeue();
        }

        public override void Enqueue(T item)
        {
            queue.Enqueue(item);
        }

        public override T Peek()
        {
            if (queue.Count == 0)
            throw new InvalidOperationException("The queue is empty.");
            return queue.Peek();
        }
        }
    }

