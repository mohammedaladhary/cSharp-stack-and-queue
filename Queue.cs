using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_and_queue
{
    internal class Queue
    {
        private int front;
        private int rear;
        private int size;
        private int[] queue;

        public Queue(int c)
        {
            front = 0;
            rear = 0;
            size = c;
            queue = new int[size];
        }
        private bool ifFull()
        {
            return size == rear;
        }
        private bool isEmpty()
        {
            return front == rear;
        }
        public void enqueue(int value)
        {
            // check if queue is full
            if (ifFull())
            {
                Console.WriteLine($"Queue is full to add {value}");
                return;
            }

            else
            {
                queue[rear++] = value;
            }
            return;
        }

        public void dequeue()
        {
            // if queue is empty
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            // 5 <-- 6 <-- 7  5 is the rear here and will be removed 
            else
            {
                for (int i = 0; i < rear - 1; i++)
                {
                    queue[i] = queue[i + 1];
                }

                if (rear < size)
                    queue[rear] = 0;

                rear--;
            }
            return;
        }

        // print queue elements
        public void queueDisplay()
        {
            int i;
            if (isEmpty())
            {
                Console.Write("Queue is Empty");
                return;
            }

            // traverse front to rear and print elements
            for (i = front; i < rear; i++)
            {
                Console.WriteLine(queue[i]);
            }
            return;
        }

        // print front of queue
        public void peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            Console.Write("Peek(front) Element is:" +queue[front]);
            return;
        }
    }
}