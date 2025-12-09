using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_11_25
{
    internal class PrintNumbersUsingThread
    {
        public static void Main(string[] args)
        {
            
               Task task1 = Task.Run(() => //We use them to run code concurrently and make the program more efficient.
               {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine(i);
                }
            });
           
             Task task2 = Task.Run(() =>
            {
                for (int i = 6; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }
            });
            
             Task task3 = Task.Run(() =>
            {
                Console.WriteLine("All numbers printed!");
            });
            
             Task.WaitAll(task1, task2, task3);

             Console.ReadLine();
        }
    }
}
