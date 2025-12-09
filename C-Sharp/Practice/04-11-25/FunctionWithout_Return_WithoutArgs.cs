using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_11_25
{
    internal class FunctionWithout_Return_WithoutArgs
    {
        static void Main(string[] args)
        {
            Addition();
        }
         static void Addition()
        {
            Console.WriteLine("Enter the number1: ");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number2: ");
            int num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Addition is: "+(num1+num2));
             
        }
    }
}
