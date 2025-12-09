using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_11_25
{
    public delegate void Calculator(int x ,int y);
    internal class Demo2
    {
        public static void Add(int x, int y)
        {
            Console.WriteLine(x+y);
        }
        public static void Substract(int x, int y)
        {
            Console.WriteLine(x-y);
        }

         static void Main(string[] args)
        {
            Calculator cl = Add;
            Add(10, 2);
            cl = Substract;
            Substract(20, 10);
          
        }
    }
}
