namespace stack_and_queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Stack stack = new Stack(5);

            stack.push(10);
            stack.push(20);
            stack.push(30);
            stack.push(40);
            stack.push(45);
            stack.pop();
            stack.pop();
            stack.peek();
        }
    }
}