using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    class Queue<T>
    {
            Node<T> front;
            //Enqueue---->inserting node at the end of list
            public void Enqueue(T value)
            {
                Node<T> queue = new Node<T>(value);
                if (front == null)
                {
                    front = queue;
                }
                else
                {
                    Node<T> rear = front;
                    while (rear.Next != null)
                    {
                        rear = rear.Next;
                    }
                    rear.Next = queue;
                }
            }
        //Display elements in Queue
            public void Display()
            {
                if (front == null)
                {
                    Console.WriteLine("Queue is empty!!");
                }
                else
                {
                    Node<T> temp = front;
                    while (temp != null)
                    {
                        Console.WriteLine(""+temp.value);
                        temp = temp.Next;
                    }
                }
            }
    }
}
