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
        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("No element to pop");
            }
            else
            {
                top = top.Next;
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
        public void Display()
        {
            if(top==null)
            {
                Console.WriteLine("Stack is empty!!");
            }
            else
            {
                Node<T> temp = top;
                while(temp !=null)
                {
                    Console.WriteLine("" + temp.value);
                    temp = temp.Next;
                }
            }
        }
    }
}