using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_11_25
{
    public delegate void numbers(int x, int y);
    internal class Demo5
    {
        public static void Add(int x,int y)
        {
            Console.WriteLine( x+y);
        }
        public static void sub(int x,int y)
        {
            Console.WriteLine( x-y);
        }
        public static void Mul(int x, int y)
        {
            Console.WriteLine( x*y);
        }
        public static void ProcessNumbers(int a, int b, numbers op)
        {
            op(a, b);
        }
        public static void Main(string[] args)
        {
            ProcessNumbers(10, 12, Add);
            ProcessNumbers(20, 10, sub);
            ProcessNumbers(30, 40, Mul);
        }
    }
}
