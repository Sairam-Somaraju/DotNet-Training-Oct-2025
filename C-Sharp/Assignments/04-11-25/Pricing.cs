using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_11_25
{
    internal static class Pricing
    {
        public static decimal CalculateGST(decimal amount)
        {
            return amount * 0.18m;  
        }

        public static bool TryGetWeekendSurcharge(DateTime rideDate, out decimal percent)
        {
            if (rideDate.DayOfWeek == DayOfWeek.Saturday || rideDate.DayOfWeek == DayOfWeek.Sunday)
            {
                percent = 0.10m;  
                return true;
            }
            percent = 0;
            return false;
        }

        public static decimal AddOnsCost(params string[] addOns)
        {
            decimal total = 0;
            foreach (var addOn in addOns)
            {
                switch (addOn.ToLower())
                {
                    case "child-seat": total += 50; break;
                    case "fast-tag": total += 100; break;
                    case "priority-pickup": total += 75; break;
                    case "extra-luggage": total += 60; break;
                }
            }
            return total;
        }

       
        public static void TryApplyCoupon_ByValue(decimal total, decimal couponAmount)
        {
            total = total-couponAmount;  
        }

         public static void ApplyCoupon_ByRef(ref decimal total, decimal couponAmount)
        {
            total -= couponAmount;
        }

         
        public static void RedeemLoyalty(ref int points, ref decimal total)
        {
            int redeemable = Math.Min(points, (int)total);
            total -= redeemable;
            points -= redeemable;
        }
    

}
}
