using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_and_queue
{
    internal class Stack
    {
        private int[] elements;
        private int top;

        public Stack(int size)
        {
            this.elements = new int[size];
            top = -1;
        }

        public void push(int value)
        {
            //if (top >= elements.Length - 1) // if the stuck is full
            if (isFull())
            {
                Console.WriteLine("The Stack is Full");
                return;
            }
            elements[++top] = value;
        }
        public int pop()
        {
            //if (top == -1) // if the stack is empty
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            return elements[top--];
        }
        public int peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
            }
            return elements[top];
        }
        private bool isEmpty()
        {
            return top == -1;
        }
        private bool isFull()
        {
            return top >= elements.Length - 1;
        }
    }
}
