using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_11_25
{
    internal class ParamsDemo
    {
        public static void Main (string[] args)
        {
            Console.WriteLine("Sum of Integers: " + SumofIntegers(10, 30));
            Console.WriteLine("Sum of Integers: " + SumofIntegers(78, 30,10,71));
            Console.WriteLine("Sum of Integers: " + SumofIntegers(190, 310,34,87,65));

        }

        public static int SumofIntegers(params int[] values)
        {
            int total = 0;
            foreach (int nums in values)
            {
                total += nums;
            }
            return total;
        }
    }
}
