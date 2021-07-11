using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    class Stack<T>
    {
        public Node<T> top;

        public void Push(T value)
        {
            Node<T> stack = new Node<T>(value);
            if (top == null)
            {
                top = stack;
            }
            else
            {
                stack.Next = top;
                top = stack;
            }
        }
        public void Peek()
        {
            if (top == null)
            {
                Console.WriteLine("No Elements");
                return;
            }
            Console.WriteLine("The top element of the stack is" + " " + top.value);
        }
    }
}