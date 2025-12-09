using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_11_2025
{
    internal class PaymentMethod
    {
        public virtual string Provider => "Generic Payment Provider";

        public virtual bool ProcessPayment(decimal amount)
        {
            if(amount>0)
            {
                Console.WriteLine($"Processing payment of {amount:C} through {Provider}.");
                return true;
            }
            else
            {
                return false;
            }
        }
        public void samplePayment()
        {
            Console.WriteLine("This is a samplke payment method");
        }
    }
}
