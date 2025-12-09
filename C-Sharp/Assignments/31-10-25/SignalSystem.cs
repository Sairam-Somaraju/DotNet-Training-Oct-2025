using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_10_2025
{
    internal class SignalSystem
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enetr the colour..");
            string colour = Console.ReadLine();
            if (colour == "Red")
            {
                Console.WriteLine("Action: Stop.");
            }
            else if (colour == "Yellow")
            {
                Console.WriteLine("Action: Get Ready");

            }
            else
            {
                Console.WriteLine("Action: Go..");
            }
            Console.WriteLine("*****************");
            Console.ReadLine();
        }
    }
}
