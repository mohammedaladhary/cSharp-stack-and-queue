namespace stack_and_queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //---------------------stack-----------------------
            Stack stack = new Stack(5);

            ////inserting elements in the stack
            //stack.push(10);
            //stack.push(20);
            //stack.push(30);
            //stack.push(40);
            //stack.push(45);

            //stack.PrintStack();
            ////removing elements from the stack
            //stack.pop();
            //stack.pop();
            //Console.WriteLine("Peek element is: "+stack.peek());
            //stack.PrintStack();


            //print Queue elements


            //---------------------queue----------------------
            Queue queue = new Queue(4);

            // inserting elements in the queue
            queue.enqueue(20);
            queue.enqueue(30);
            queue.enqueue(40);
            queue.enqueue(50);

            // print Queue elements
            queue.queueDisplay();

            // queue is full
            queue.enqueue(60);

            queue.dequeue();
            queue.dequeue();

            //display updated queue after deleting some elements
            Console.WriteLine("updated queue: ");
            queue.queueDisplay();

            // print front of the queue
            queue.peek();
        }
    }
}