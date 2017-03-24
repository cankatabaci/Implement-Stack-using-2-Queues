using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implement_Stack_using_2_Queues
{
    public class Stack
    {
        Queue q1 = new Queue(10);
        Queue q2 = new Queue(10);

        public void Push(object o)
        {
            q1.Enqueue(o);
        }

        public object Pop()
        {
            if (q1.IsEmpty())
            {
                throw new Exception("Queue 1 is empty!");
            }
            else
            {
                while (q1.count > 1)
                {
                    q2.Enqueue(q1.Dequeue());
                }

                object value = q1.Dequeue();

                while (!q2.IsEmpty())
                {
                    q1.Enqueue(q2.Dequeue());
                }

                return value;
            }
        }

    }
}
