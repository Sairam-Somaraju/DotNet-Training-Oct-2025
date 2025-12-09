using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocceryBillApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of Customers: ");
            int noofTimes = Convert.ToInt32(Console.ReadLine());
            GrocceryBillingSystem[] customers = new GrocceryBillingSystem[noofTimes];
            for (int i = 0; i < customers.Length; i++)
            {
                customers[i] = new GrocceryBillingSystem();
                Console.WriteLine($"\nEnter the Prices for Customer  {i + 1}  ");
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"ENter item1 Price {j + 1}: ");
                    customers[i].items[j] = Convert.ToInt32(Console.ReadLine());
                }
            }
             

            Console.WriteLine("******Items List********");
            for(int i=0;i<noofTimes;i++)
            {
                customers[i].DisplayResult();
            }


        }
    }
}
