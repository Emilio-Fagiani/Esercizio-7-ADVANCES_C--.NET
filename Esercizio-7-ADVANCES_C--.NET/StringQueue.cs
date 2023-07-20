using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_7_ADVANCES_C__.NET
{
    public class StringQueue<T> : MyQueue<T>
    {
        public override T Dequeue()
        {
            if(queue.Count == 0)
            throw new NotImplementedException();
            return queue.Dequeue();
        }

        public override void Enqueue(T value)
        {
          queue.Enqueue(value);
        }

        public override T Peek()
        {
            if(queue.TryPeek == null )
            throw new NotImplementedException();
            return queue.Peek();
        }
    }
}
