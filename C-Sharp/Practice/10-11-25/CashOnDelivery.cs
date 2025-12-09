using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_11_2025
{
    internal class CashOnDelivery: PaymentMethod
    {
        public override string Provider => "Cash On Delivery";

        //public override bool ProcessPayment(decimal amount)
        //{
        //    if (amount > 0 && amount <= 1000)
        //    {
        //        Console.WriteLine($"Processing cash on delivery payment of {amount:C} through {Provider}");
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("cash on delivery failed");
        //        return false;
        //    }

        //}
    }
}
