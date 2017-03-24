using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implement_Stack_using_2_Queues
{
    public class Queue
    {
        private object[] Q;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        public int count = 0;

        public Queue(int size)
        {
            this.size = size;
            Q = new object[size];
        }

        public void Enqueue(object o)
        {
            if ((count == size) || (rear == size - 1))
            {
                throw new Exception("Queue is full!");
            }

            if (front == -1)
            {
                front = 0;
            }

            Q[++rear] = o;
            count++;
        }

        public object Dequeue()
        {
            if (IsEmpty())
                throw new Exception("Queue is empty!");

            object tmp = Q[front];
            Q[front] = null;
            front++;
            count--;
            return tmp;
        }

        public object Peek()
        {
            return Q[front];
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }

        public string DisplayElements()
        {
            string Ifade = "";

            if (count == 0)
                throw new IndexOutOfRangeException();
            else
            {
                for (int i = front; i <= rear; i++)
                {
                    Ifade += Q[i].ToString() + " ";
                }
            }

            return Ifade;
        }

    }
}
