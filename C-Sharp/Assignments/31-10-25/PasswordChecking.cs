using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_10_2025
{
    internal class PasswordChecking
    {
        static void Main(string[] args)
        {
            String password;
            Console.WriteLine("Enter the Password...");
            password = Console.ReadLine();

            if (password.Length < 6)
            {
                Console.WriteLine("Password Strenth is: Weak..");
            }
            else if (password.Length >= 6 && password.Length <= 10)
            {
                Console.WriteLine("Password Strenth is: Medium.. ");
            }
            else
            {
                Console.WriteLine("Password Strenth is: Strong..");
            }
        }
    }
}
