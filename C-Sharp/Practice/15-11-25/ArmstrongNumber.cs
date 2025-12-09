using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_11_25
{
    internal class ArmstrongNumber
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (IsArmstrong(num))
                Console.WriteLine($"{num} is an Armstrong number.");
            else
                Console.WriteLine($"{num} is not an Armstrong number.");
        }
        static bool IsArmstrong(int number)
        {
            int sum = 0;
            int temp = number;
            int digits = number.ToString().Length;

            while (temp > 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, digits);
                temp /= 10;
            }

            return sum == number;
        }
    }
}
