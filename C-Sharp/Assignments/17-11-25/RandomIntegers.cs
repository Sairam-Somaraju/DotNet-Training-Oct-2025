using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _17_11_25
{
    internal class RandomIntegers
    {
        public static void Main(string[] args)
        {
            Random random = new Random(); //Random is used to generate random numbers.We create one instance and share it across tasks.


            Task<int> task1 = Task.Run(() =>
            {
                int value = random.Next(1, 60);  
                WriteLine("Task 1 generated: " + value);
                return value;
            });
 
            Task<int> task2 = Task.Run(() =>
            {
                int value = random.Next(1, 70);
                 WriteLine("Task 2 generated: " + value);
                return value;
            });
            
            Task<int> task3 = Task.Run(() =>
            {
                int value = random.Next(1, 80);
                 WriteLine("Task 3 generated: " + value);
                return value;
            });

             Task.WhenAll(task1, task2, task3).ContinueWith(t => //it will run after  all tasks finish
            {
                 int sum = 0;
                foreach (var result in t.Result)
                {
                    sum += result;
                }
                 WriteLine("Sum of all random numbers: " + sum);
            }).Wait(); // Wait here to keep the console open until done

             
        }
    }
}
