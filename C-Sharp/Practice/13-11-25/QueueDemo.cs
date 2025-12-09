using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_11_25
{
    internal class QueueDemo
    {
        public static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue("sai");
            queue.Enqueue("trainee");
            queue.Enqueue("28400");

            foreach (Object item in queue)
            {
                Console.WriteLine(item);
            }


            queue.Dequeue(); //it will remove the first item  

            Console.WriteLine("Total items in Queue: "+queue.Count);// it will coungt  the number itmes in queue

            Console.WriteLine("Top item in Queue: "+queue.Peek());// it will print the first item in queue

        }
    }
}
