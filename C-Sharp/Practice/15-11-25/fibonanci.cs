using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_11_25
{
    internal class fibonanci
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number of terms: ");
            int n = int.Parse(Console.ReadLine());

            int a = 0, b = 1, c;

            Console.Write("Fibonacci Series: ");

            for (int i = 1; i <= n; i++)
            {
                Console.Write(a + " ");
                c = a + b;
                a = b;
                b = c;

            }
        }
    }
}
