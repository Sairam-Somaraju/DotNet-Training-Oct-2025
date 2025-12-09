using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_11_25
{
    internal class Ride
    {
        public Vehicle Vehicle;
        public Customer Customer;
        public DateTime RideDate;
        public decimal DistanceKm;
        public Ride(Vehicle vehicle, Customer customer, DateTime rideDate, decimal distanceKm)
        {
            Vehicle = vehicle;
            Customer = customer;
            RideDate = rideDate;
            DistanceKm = distanceKm;
        }
 
        public void ComputeBill(out decimal subtotal, out decimal gst, out decimal total, params string[] addOns)
        {
            subtotal = Vehicle.BaseFare + (Vehicle.PerKmRate * DistanceKm);
            subtotal += Pricing.AddOnsCost(addOns);

            if (Pricing.TryGetWeekendSurcharge(RideDate, out decimal weekendPercent))
                subtotal += subtotal * weekendPercent;

            gst = Pricing.CalculateGST(subtotal);
            total = subtotal + gst;
        }
 
        public void PrintInvoice(decimal subtotal, decimal gst, decimal total, string[] addOns, decimal coupon)
        {
            Console.WriteLine("========= RIDE EASY INVOICE =========");
            Console.WriteLine($"Customer: {Customer.Name}");
            Console.WriteLine($"Vehicle: {Vehicle.Type}");
            Console.WriteLine($"Date: {RideDate:dd-MMM-yyyy} ({RideDate.DayOfWeek})");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Base Fare:         ₹{Vehicle.BaseFare,8}");
            Console.WriteLine($"Distance ({DistanceKm} km): ₹{Vehicle.PerKmRate * DistanceKm,8}");
            Console.WriteLine($"Add-ons ({string.Join(", ", addOns)}): ₹{Pricing.AddOnsCost(addOns),8}");
            if (Pricing.TryGetWeekendSurcharge(RideDate, out decimal wPercent))
                Console.WriteLine($"Weekend Surcharge ({wPercent * 100}%): Included");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Sub-Total:         ₹{subtotal,8}");
            Console.WriteLine($"GST (18%):         ₹{gst,8}");
            Console.WriteLine($"Total Before Coupon: ₹{total,8}");

             
            Pricing.TryApplyCoupon_ByValue(total, coupon); 
            Pricing.ApplyCoupon_ByRef(ref total, coupon);   
            Console.WriteLine($"Coupon Applied:    -₹{coupon,8}");

            
            Pricing.RedeemLoyalty(ref Customer.LoyaltyPoints, ref total);
            Console.WriteLine($"Loyalty Redeemed. Remaining Points: {Customer.LoyaltyPoints}");

            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"FINAL AMOUNT:      ₹{total,8}");
            Console.WriteLine("=====================================");
        }
    }
}
