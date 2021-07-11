using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    class Stack<T>
    {
        public Node<T> top;
        //push elements into the stack
        public void Push(T value)
        {
            Node<T> stack = new Node<T>(value);
            //check whether top is null or not
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
        //remove element from stack
        public void Pop()
        {
            //check whether top is null or not
            if (top == null)
            {
                Console.WriteLine("No element to pop");
            }
            else
            {
                top = top.Next;
            }
        }
        //Display the first element in stack
        public void Peek()
        {
            //check whether top is null or not
            if (top == null)
            {
                Console.WriteLine("No Elements");
                return;
            }
            Console.WriteLine("The top element of the stack is" + " " + top.value);
        }
        //Display elements in the stack
        public void Display()
        {
            //check whether top is null or not
            if (top==null)
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