using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace _18_11_25
{
    internal class Demo1
    {
        static async Task Main(string[] args)  
        {
            Demo1 p = new Demo1();

            // Call any method you want to test
            p.NonParellel();
            p.Parellel();
            await p.TASKDEMO();

            Console.WriteLine("Main Method Finished");
        }

        public void NonParellel()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 16; i++)
            {
                Console.WriteLine("Non Parallel Method Running " + Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(1000);
            }
            sw.Stop();
            Console.WriteLine("Total Milliseconds = " + sw.ElapsedMilliseconds);
        }

        public void Parellel()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Parallel.For(0, 16, i =>
            {
                Console.WriteLine("Parallel Method Running " + Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(1000);
            });
            sw.Stop();
            Console.WriteLine("Total Milliseconds = " + sw.ElapsedMilliseconds);
        }

        public async Task TASKDEMO()  //  
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Method1 Called");
                    Thread.Sleep(1000);
                }
            });

            await Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Method2 Called");
                    Thread.Sleep(1000);
                }
            });

            Console.WriteLine("Both Tasks Completed Successfully");
        }
    }
}

