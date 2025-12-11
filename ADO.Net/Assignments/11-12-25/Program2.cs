using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_12_25
{
    internal class Program2
    {
        public static void Main(string[] args)
        {
            Linq_Assignment2 lq2 = new Linq_Assignment2();
            lq2.SecondHighest();
            lq2.TopHighestprice();
            lq2.ProductName();
            lq2.FilterByCoulmnName();
            lq2.MaxOfPrice();
            Console.ReadLine();
        }
    }
}
