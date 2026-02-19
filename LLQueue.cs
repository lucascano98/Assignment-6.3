using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6._3
{
    internal class Node
    {
        public Customer data;
        public Node next;

        public Node(Customer data)
        {
            this.data = data;
            this.next = null;
        }
    }
    class Queue
    {
        Node front, rear;
        int size;

        public Queue()
        {
            front = rear = null;
            size = 0;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public void Enqueue(Customer data)
        {
            Node newNode = new Node(data);
            if (IsEmpty())
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                rear.next = newNode;
                rear = newNode;
            }
            size++;
        }

        public void Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            Customer val = front.data;
            front = front.next;
            size--;

            if (IsEmpty())
                rear = null;

            Console.WriteLine($"Customer Name: {val.Name}");
            Console.WriteLine($"Phone Number: {val.PhoneNumber}");
            Console.WriteLine($"Issue Area: {val.Issue}");
        }

        public void Display()
        {
            Node temp = front;
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            while (temp != null)
            {
                Console.WriteLine($"{temp.data.Name} | {temp.data.PhoneNumber} | Issue: {temp.data.Issue}");
                temp = temp.next;
            }
            Console.WriteLine();
        }

        public int Size()
        {
            return size;
        }
    }
}
