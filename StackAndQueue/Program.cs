using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Stack And Queue ");

            Stack<int> stack = new Stack<int>();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Peek();
            stack.Pop();
            stack.Display();

            Queue<int> queue = new Queue<int>();
            Console.WriteLine("Elements in Queue");
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();

        }
    }
}
