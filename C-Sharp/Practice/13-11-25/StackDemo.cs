using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_11_25
{
    internal class StackDemo
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push("101");
            stack.Push("sai");
            stack.Push("trainee");
            stack.Push("28400");

            stack.Pop();// it will remove the last item in stack
            Console.WriteLine("After peek: "+stack.Peek());// it will print the last item in stack
            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Test value is there or not: "+stack.Contains("trainee"));
            Console.WriteLine("Total items in the stack : "+stack.Count);

        }
    }
}
