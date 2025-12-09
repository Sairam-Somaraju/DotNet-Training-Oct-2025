using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_11_2025
{
    internal class CreditCardPayment: PaymentMethod
    {
        public override string Provider => " Creditg Card Provider";

        public override bool ProcessPayment(decimal amount)
        {
            base.ProcessPayment(788);
            if(amount>0 && amount <=5000)
            {
                Console.WriteLine($" Processing credit card payment of {amount:C} through {Provider}.");
                return true;
            }
            else
            {
                Console.WriteLine("Credit card payment failed: Amount exceeds ilnit or is invalid");
                return false;
            }
        }
    }
}
