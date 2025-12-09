using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_11_25
{
    internal class FunctionwithoutReturnwithArgs
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
             Substraction(num1, num2);
        }
        public static void Substraction(int n1, int n2)
        {
            Console.WriteLine("Substraction is: "+(n1-n2));
        }
    }
}
