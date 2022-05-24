using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExp
{
    public class Stack
    {
        Node top;
        public Stack()
        {
            top = null;
        }
        public void push(int data)
        {
            Node newnode = new Node(data);
            newnode.next = top;
            top = newnode;
        }

        public  void pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            Console.WriteLine("\n");
            this.top = this.top.next;
        }
        public void peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("Top element is: " + top.data);
            }
        }
        public void Display()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            Node temp = top;
            while (temp != null)
            {
                Console.Write("| " + temp.data + " |");
                temp = temp.next;
            }
        }
    }
}
