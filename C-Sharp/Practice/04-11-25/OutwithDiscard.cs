using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_11_25
{
    internal class OutwithDiscard
    {
        public static void Main(string[] args)
        {
            calculate(10,20, out int sum, out int _, out int mul);
            Console.WriteLine($"Addition is: {sum}\n  multiplication is: {mul}");
        }
        public static void calculate(int a, int b, out int sum,out int diff, out int mul)
        {
            sum = a + b;
            diff = b - a;
            mul = a * b;
        }
    }
}
