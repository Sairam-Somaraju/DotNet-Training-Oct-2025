using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_11_2025
{
    internal class OverridingDemo
    {
        public static void Main(string[] args)
        {
            CreditCardPayment cardPayment = new CreditCardPayment();
            cardPayment.ProcessPayment(1000);
            cardPayment.samplePayment();
            Console.WriteLine($"{cardPayment.Provider}");
            CashOnDelivery delivery = new CashOnDelivery();
            delivery.ProcessPayment(4000);
Console.ReadLine();            
            
        }
    }
}
