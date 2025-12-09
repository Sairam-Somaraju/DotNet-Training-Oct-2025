using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_10_2025
{
    internal class MovieTicketsSystem
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the age...");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the showtime..");
            int time = Convert.ToInt32(Console.ReadLine());

            if (age < 12)
            {
                Console.WriteLine("Ticket price is: " + 150);
            }
            else if (age >= 12 && time <= 18)
            {
                Console.WriteLine("Ticket Price is: " + 250);
            }
            else
            {
                Console.WriteLine("Ticket price is: " + 300);
            }
            Console.WriteLine("*****************");
            Console.ReadLine();
        }
    }
}
