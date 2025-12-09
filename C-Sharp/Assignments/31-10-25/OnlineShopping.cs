using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_10_2025
{
    internal class OnlineShopping
    {
        public static void Main(string[] args)
        {
            int purAmount;
            Console.WriteLine("ENter the purchase Amount..");
            purAmount = Convert.ToInt32(Console.ReadLine());
            if (purAmount < 1000)
            {
                Console.WriteLine("No discount");

            }
            else if (purAmount >= 1000 && purAmount <= 5000)
            {
                int discount = (10 / 100) * purAmount;
                int total = discount + purAmount;
                Console.WriteLine(total);
            }
            else
            {
                int discount = (20 / 100) * purAmount;
                int total = discount + purAmount;
                Console.WriteLine(total);
            }
        }
    }
}
