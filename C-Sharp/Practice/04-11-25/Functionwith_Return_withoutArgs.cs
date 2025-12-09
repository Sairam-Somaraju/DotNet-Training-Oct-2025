using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_11_25
{
    internal class Functionwith_Return_withoutArgs
    {
        public static void Main(string[] args)
        {
           
            Console.WriteLine("Multiplication is: "+ Multiplication());
        }

        public static int Multiplication()
        {
            Console.WriteLine("Enter the number1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            return (num1 * num2);
        }
    }
}
