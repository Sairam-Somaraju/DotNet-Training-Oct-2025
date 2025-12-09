using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_11_25
{

    internal class Demo7
    {
        public static void Main(string[]args)
        {
            Func<int, int, int> add = (a, b) => a + b;
            Func<int, int, int> multiply = (a, b) => a * b;

            int x = 6;
            int y = 4;
            Console.WriteLine($"Addition :{x}+{y}={add(x,y)}");
            Console.WriteLine($"Multiplication: {x}*{y}={multiply(x,y)}");
        }
    }
}
