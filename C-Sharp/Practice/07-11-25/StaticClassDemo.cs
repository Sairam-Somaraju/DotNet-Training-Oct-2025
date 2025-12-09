using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_11_25
{
    static class StaticClassDemo
    {
        static double pi = 3.14519;
        public static int  Add(int a, int b)
            {
                return (a + b);
            }

        public static int Sub(int a, int b)
        {
            return (a - b);
        }
        public static int Mul(int a, int b)
        {
            return (a * b);
        }
        public static double Div(int a, int b)
        {
             return (b!=0 )? (a / b) : throw new DivideByZeroException("Denaminator can not be Zero");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Addition is: "+ StaticClassDemo.Add(100, 250));

            Console.WriteLine("Substarction is: " + StaticClassDemo.Sub(160, 30));

            Console.WriteLine("Multiplication is: " + StaticClassDemo.Add(32, 20));

            Console.WriteLine("Division  is: " + StaticClassDemo.Div(5000, 15));


        }
    }
}
