using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_11_25
{
    internal class RideEasyApplication
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Welcome to RideEasy Fare Calculator ===");

             
            Console.Write("Enter customer name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your loyalty points: ");
            int points;
            if (!int.TryParse(Console.ReadLine(), out points))
                points = 0;  

            Console.Write("Enter vehicle type (Hatchback / Sedan / SUV): ");
            string vehicleType = Console.ReadLine();

            
            Vehicle vehicle;
            if (vehicleType.ToLower() == "hatchback")
                vehicle = new Vehicle("Hatchback", 100, 12);
            else if (vehicleType.ToLower() == "sedan")
                vehicle = new Vehicle("Sedan", 150, 15);
            else
                vehicle = new Vehicle("SUV", 200, 18);

            Console.Write("Enter distance travelled (in km): ");
            decimal distance;
            decimal.TryParse(Console.ReadLine(), out distance);

            Console.Write("Enter ride date (yyyy-mm-dd): ");
            DateTime rideDate;
            DateTime.TryParse(Console.ReadLine(), out rideDate);

            Console.Write("Enter coupon amount (0 if none): ");
            decimal coupon;
            decimal.TryParse(Console.ReadLine(), out coupon);

            Console.Write("Enter add-ons (comma separated, e.g., child-seat, fast-tag): ");
            string addOnInput = Console.ReadLine();
            string[] addOns = addOnInput.Split(',', (char)StringSplitOptions.RemoveEmptyEntries);

             Customer customer = new Customer(name, points);
            Ride ride = new Ride(vehicle, customer, rideDate, distance);

             decimal subtotal, gst, total;
            ride.ComputeBill(out subtotal, out gst, out total, addOns);
            ride.PrintInvoice(subtotal, gst, total, addOns, coupon);

         }
    }
}
    

