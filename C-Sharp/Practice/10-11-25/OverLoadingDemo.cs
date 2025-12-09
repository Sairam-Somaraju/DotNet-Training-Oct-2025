using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_11_2025
{
    class OverLoading
    {
        public void CustomerInfo(int id)
        {
            Console.WriteLine("Customer Id: "+id);
        }
        public void CustomerInfo(String name)
        {
            Console.WriteLine("Customer name: " + name);
        }
        public void CustomerInfo(String name,int id)
        {
            Console.WriteLine("Customer name: " + name);
            Console.WriteLine("Customer Id: " + id);
        }
        public void CustomerInfo(int id,String name)
        {
            Console.WriteLine("Customer Id: " + id);
            Console.WriteLine("Customer name: " + name);
        }
    }
    internal class OverLoadingDemo
    {
        static void Main(string[] args)
        {
            OverLoading demo = new OverLoading();
            demo.CustomerInfo(101);
            demo.CustomerInfo("Sai");
            demo.CustomerInfo("Ram",102);
            demo.CustomerInfo(103,"Ram");
            Console.ReadLine();
        }
    }
}
