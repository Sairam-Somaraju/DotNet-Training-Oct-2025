using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_11_25
{
    internal class Palindrome
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (IsPalindrome(num))
                Console.WriteLine($"{num} is a palindrome.");
            else
                Console.WriteLine($"{num} is not a palindrome.");
        }
        static bool IsPalindrome(int number)
        {
            int original = number;
            int reverse = 0;

            while (number > 0)
            {
                int digit = number % 10;
                reverse = reverse * 10 + digit;
                number /= 10;
            }

            return original == reverse;
        }
    }
}
