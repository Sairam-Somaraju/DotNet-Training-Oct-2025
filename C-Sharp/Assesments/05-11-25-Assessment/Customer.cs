using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_11_UtilityBillingSystem
{
    internal class Customer
    {
        public int CustomerId;
        public string CustomerName;
        public int usage;
        public int ServiceCharge;

        public Customer(int id, string name)
        {
            CustomerId = id;
            CustomerName = name;
            ServiceCharge = GetServiceCharge();
        }
        public static int GetServiceCharge()
        {
            return 50;
        }

        public void CalculateBill(out double total, out double netPayable, out double tax)
        {
            total = usage * 7;
            tax = total * 0.10;
            netPayable = total + tax + ServiceCharge;

        }
        public void TotalUsage(params int[] arr)
        {
            int val = 0;
            foreach (int num in arr)
            {
                val += num;
            }
            usage = val;
        }

        public void PrintInvoice(double total, double netpayable, double tax)
        {
            Console.Write("\n Utility Bill \n");
            Console.WriteLine($"Customer Id : {CustomerId}\nCustomerName : {CustomerName}" + $"\nService Charge : Rs.{ServiceCharge}\nTotal Usage : Rs.{total}" + $"\nTax Applied : Rs.{tax}\nNet Payable : Rs.{netpayable}");
             
        }
    }
}
