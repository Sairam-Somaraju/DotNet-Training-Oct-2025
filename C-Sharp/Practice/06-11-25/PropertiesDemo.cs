using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_11_2025
{
    class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public void DisplayCustomerInfo()
        {
            Console.WriteLine("Customer Id:  "+CustomerId);
            Console.WriteLine("CustomerName: "+CustomerName);
            Console.WriteLine("CustomerEmail:" + Email);
            Console.WriteLine("Customerphone Nuumber: "+PhoneNumber);

        }

    }

    internal class PropertiesDemo
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Console.WriteLine("Enter the customer id , name, email and phonenumber");
            customer.CustomerId=Convert.ToInt32(Console.ReadLine());
            customer.CustomerName=Console.ReadLine();
            customer.Email=Console.ReadLine();
            customer.PhoneNumber=Console.ReadLine();
            customer.DisplayCustomerInfo();
            
        }
    }
}
