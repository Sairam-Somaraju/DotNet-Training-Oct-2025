using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_10_2025
{
    internal class RestarauntBill
    {
        public static void Main(String[] args)
        {
            int billAmount;
            Console.WriteLine("Enter the bill Amount..");
            billAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of persons..");
            int persons = Convert.ToInt32(Console.ReadLine());

            if (billAmount > 1000)
            {
                double gst = 5;
                double serviceCharge = 10;
                double total = ((gst + serviceCharge) / 100) * billAmount;
                double totalAmount = total + billAmount;
                Console.WriteLine("Each person Should pay: " + (totalAmount / persons));
            }
            Console.WriteLine("*****************");
            Console.ReadLine();
        }
    }
}
