using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _20_11_25
{
    internal class OCP
    {
        public interface IDiscount
        {
            decimal GetDiscount();
        }
        public class VipDiscount : IDiscount
        {
            public decimal GetDiscount()
            {
                return 0.8m;
            }
        }
        public class EmployeeDiscount : IDiscount
        {
            public decimal GetDiscount()
            {
                return 0.5m;
            }
        }
        public class NoDiscount : IDiscount
        {
            public decimal GetDiscount()
            {
                return 0m;
            }
        }
        public class DiscountService
        {
            public decimal ApplyDiscount(IDiscount discountType)
            {
                return discountType.GetDiscount();
            }
        }
        public static void Main(string[] args)
        {
            var service = new DiscountService();

            decimal vipDiscount = service.ApplyDiscount(new VipDiscount());
            decimal empDiscount = service.ApplyDiscount(new EmployeeDiscount());
            decimal noDiscount = service.ApplyDiscount(new NoDiscount());

            WriteLine("Vip Discount: "+vipDiscount);
            WriteLine("Emp Discount: " + empDiscount);
            WriteLine("No Discount: " + noDiscount);

        }
    }
}
