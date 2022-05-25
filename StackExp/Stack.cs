using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExp
{
    // Stack perform LIFO/FILO operation
    // In Stack Perform PUSH,POP,PEEK Operation
    public class Stack
    {
        Node top;
        public Stack() 
        {
            top = null;
        }
        public void push(int data) // insert element into stack
        {
            Node newnode = new Node(data);
            newnode.next = top;
            top = newnode;
        }

        public  void pop() // delete element from stack
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            Console.WriteLine("\n");
            this.top = this.top.next;
        }
        public void peek() // Topmost element from stack
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
