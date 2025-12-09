using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_11_25
{
    interface IPaymentGateway
    {
        void MakePayment(decimal amount);
    }

      class PaymentHelper
    {
        public static void LogTransaction(decimal amount)
        {
            Console.WriteLine($"Log Payment of {amount} processed on {DateTime.Now}");
        }

        public static void ShowSupportedPayments()
        {
            Console.WriteLine("Supported Payment Methods:");
            Console.WriteLine("1. Credit Card");
            Console.WriteLine("2. UPI");
            Console.WriteLine("3. Wallet");
            Console.WriteLine("4. (Future) PayPal, NetBanking, etc.");
        }
    }

     class CreditCardPayment : IPaymentGateway
    {
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Processing Credit Card Payment of {amount}");
            PaymentHelper.LogTransaction(amount);  
        }
    }

     class UPIPayment : IPaymentGateway
    {
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Processing UPI Payment of {amount}");
            PaymentHelper.LogTransaction(amount);
        }
    }

     class WalletPayment : IPaymentGateway
    {
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Processing Wallet Payment of {amount}");
            PaymentHelper.LogTransaction(amount);
        }
    }


     internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SMART PAYMENT GATEWAY\n");

            PaymentHelper.ShowSupportedPayments();

            Console.WriteLine("\nChoose Payment Method (1-3): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            IPaymentGateway gateway = null;

            switch (choice)
            {
                case 1:
                    gateway = new CreditCardPayment();
                    break;
                case 2:
                    gateway = new UPIPayment();
                    break;
                case 3:
                    gateway = new WalletPayment();
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    return;
            }

            Console.WriteLine("Enter amount to pay: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            gateway.MakePayment(amount);

            Console.WriteLine("\nPayment Completed Successfully!");
        }
    }
}
