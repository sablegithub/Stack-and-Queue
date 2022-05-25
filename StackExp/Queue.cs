using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExp
{
    public class QueueExp
    {
        //Queue perform FIFO/LILO Operation
        //insertion done on rare end ,also called as tail
        //deleation done on front end ,also called as head
        //peek element means front end element
        public void QueueOperation()
        {
            Queue objqueue = new Queue();
            objqueue.Enqueue(56);
            objqueue.Enqueue(70);
            objqueue.Enqueue(30);
            Console.WriteLine("Enqueue Element :");
            foreach(var item in objqueue)
            {
                
                Console.WriteLine(" " +item);
            }
            Console.WriteLine("-----------");

            objqueue.Dequeue();
            Console.WriteLine("Dequeue Element:");
            foreach( var item in objqueue)
            {
                Console.WriteLine(" "+item);
            }
        }

        
    }
}
