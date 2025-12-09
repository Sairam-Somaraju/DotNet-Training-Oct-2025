using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_10_2025
{
    internal class EmployeeInfo
    {
        public static void Main(string[] args)
        {
            int sal;
            Console.WriteLine("Enter the Salary: ");
            sal = Convert.ToInt32(Console.ReadLine());
            int exp;
            Console.WriteLine("Enter the number years Experience..");
            exp = Convert.ToInt32(Console.ReadLine());
            if (exp > 10)
            {
                double amount = sal * 0.20;
                Console.WriteLine(amount);
                double totalsal = amount + sal;
                Console.WriteLine(totalsal);
            }
            else if (exp > 5 && exp < 10)
            {
                double amount = sal * 0.10;
                double totalsal = amount + sal;
                Console.WriteLine(totalsal);
            }
            else
            {
                double amount = sal * 0.05;
                double totalsal = amount + sal;
                Console.WriteLine(totalsal);
            }
        }
    }
}
