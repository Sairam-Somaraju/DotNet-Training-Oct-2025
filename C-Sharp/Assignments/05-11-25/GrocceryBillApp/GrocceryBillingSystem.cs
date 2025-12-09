using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocceryBillApp
{
    internal class GrocceryBillingSystem
    {
        public int[] items = new int[3];
        public void CalculateBill( out double total,  out double discount,  out double finalBill)
        {
            total = 0;
            for (int i = 0; i < items.Length; i++)
            {
                total += items[i];
            }
            if(total>5000)
            {
                 discount =( (20.0/ 100.0) * total);
                 
            }
            else if (total >2000 && total<5000)
            {
                  discount =( (10.0 / 100.0) * total);
                
            }
             else if (total >1000 && total<2000)
            {
                 discount = ((5.0 / 100.0) * total);
               
            }
            else
            {
                discount = 0;
                Console.WriteLine("No Discount");
            }
            finalBill = total - discount;
        }
        public void DisplayResult()
        {
            CalculateBill( out double total, out double discount,  out double finalBill);
                Console.WriteLine("-----------------------------");
            Console.WriteLine("Item Prices: {0}, {1}, {2}", items[0], items[1], items[2]);
            Console.WriteLine("Total Bill Before Discount: " + total);
            Console.WriteLine("Discount Applied: " + discount);
            Console.WriteLine("Final Bill After Discount: " + finalBill);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Final Bill is after discount: " + finalBill);
        }

    }
}
