using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_11_25
{
    interface IPaymentProcessor
    {
        void MakePayment(decimal amount);//abstract method
    }
    class RefundablePaymentProcessor
    {

        public void RefundPayment(decimal amount)
        {
            Console.WriteLine($"Refunding payment of {amount:C}.");
        }
    }

    class PayPalProcessor : RefundablePaymentProcessor, IPaymentProcessor //ILoger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[LOG] {DateTime.Now} : {message}");
        }

        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount:C} through PayPal.");
        }
        //public void RefundPayment(decimal amount)
        //{
        //    Console.WriteLine($"Refunding payment of {amount:C} through PayPal.");
        //}
    }
    class UPIPayment : IPaymentProcessor
    {
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount:C} through UPI.");
        }
        public void RefundPayment(decimal amount)
        {
            Console.WriteLine($"Refunding payment of {amount:C} through UPI.");
        }
    }

    class NetBanking : IPaymentProcessor
    {
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount:C} through Net Banking.");
        }
        public void RefundPayment(decimal amount)
        {
            Console.WriteLine($"Refunding payment of {amount:C} through Net Banking.");
        }
    }
    internal class ILoger
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter the Payment Option would you choose");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    PayPalProcessor paypal = new PayPalProcessor();
                    paypal.MakePayment(1000);
                    paypal.RefundPayment(500.45m);
                    paypal.Log("Payment of 1000 made through PayPal.");
                    break;
                case 2:
                    IPaymentProcessor upi = new UPIPayment();
                    upi.MakePayment(2000);
                    break;
                case 3:
                    IPaymentProcessor netbanking = new NetBanking();
                    netbanking.MakePayment(3000);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
    }
