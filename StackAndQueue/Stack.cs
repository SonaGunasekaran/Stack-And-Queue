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
    }
}