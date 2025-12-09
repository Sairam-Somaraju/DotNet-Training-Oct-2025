using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_11_2025
{
    class OnlineStore
    {
        public void Checkout(int Price)
        {
            Console.WriteLine("Product_Price : " + Price);
        }
        public void Checkout(int Price, int Quantity)
        {
            Console.WriteLine($"Product Price : {Price} and Product Quantity {Quantity}");
        }
        public void Checkout(string CouponCode)
        {
            Console.WriteLine($"Coupon Appply : {CouponCode}");
        }
        public void Checkout(int Price, int Quantity, string CouponCode)
        {
            int total = Price * Quantity;
            Console.WriteLine($"Total price for {Quantity} items: {total} with coupon: {CouponCode}");
        }
    }
    internal class OnlineStoreCheckOut
    {
        public static void Main(string[] args)
        {
            OnlineStore OS = new OnlineStore();
            OS.Checkout(2000);
            OS.Checkout(2000, 3);
            OS.Checkout("Flat12");
            OS.Checkout(2000, 3, "Flat12");
        }
    }
}
