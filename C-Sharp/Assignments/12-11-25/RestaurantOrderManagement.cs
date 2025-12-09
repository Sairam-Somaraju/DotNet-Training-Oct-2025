using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _12_11_25
{
    class Foodie
    {
        public int orderId { get; set; }
        public string customerName { get; set; }
        public decimal totalAmount { get; set; }

    }
    internal class RestaurantOrderManagement
    {
        static void Main(string[] args)
        {
            Foodie foodie = new Foodie();
            ArrayList list = new ArrayList();
            list.Add(new Foodie { orderId = 101, customerName = "Biryani", totalAmount = 278.34m });
            list.Add(new Foodie { orderId = 102, customerName = "friedRice", totalAmount = 150.44m });
            list.Add(new Foodie { orderId = 103, customerName = "Pizza", totalAmount = 193.78m });
            while (true)
            {
                Console.WriteLine("\n Order Details");
                Console.WriteLine("1.Add new Orders");
                Console.WriteLine("2.Display All Orders");
                Console.WriteLine("3.Search an order by Order ID.");
                Console.WriteLine("4.Remove an order by Order ID.");
                Console.WriteLine("5.Show the total number of orders.");
                Console.WriteLine("6.Sort orders by amount and display them.");
                Console.WriteLine("7.Reverse the list to show the latest orders first.");
                Console.WriteLine("8.Exit");

                Console.WriteLine("Enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter OrderId,Customer name and totalamount");
                        foodie.orderId = Convert.ToInt32(Console.ReadLine());
                        foodie.customerName = Console.ReadLine();
                        foodie.totalAmount = Convert.ToInt32(Console.ReadLine());
                        list.Add(foodie);
                        break;
                    case 2:
                        Console.WriteLine("Display All Orders");
                        foreach(Foodie item in list)
                        {
                            Console.WriteLine($" Id:{item.orderId}\n Customername: {item.customerName}\n totalAmount: {item.totalAmount}");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter the orderId to Search");
                        int searchId = Convert.ToInt32(Console.ReadLine());
                        Foodie foundOrder = null;
                        foreach (Foodie item in list)
                        {
                            if (item.orderId == searchId)
                            {
                                foundOrder = item;
                                break;
                            }
                        }
                        if (foundOrder != null)
                        {
                            Console.WriteLine($"Found Order: Id: {foundOrder.orderId}\n Customername: {foundOrder.customerName}\n totalAmount: {foundOrder.totalAmount}");
                        }
                        else
                        {
                            Console.WriteLine("Order not found");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter the order id to remove");
                        int removeId = Convert.ToInt32(Console.ReadLine());
                        Foodie orderToRemove = null;
                        foreach (Foodie item in list)
                        {
                            if (item.orderId == removeId)
                            {
                                orderToRemove = item;
                                break;
                            }
                        }
                        if (orderToRemove != null)
                        {
                            list.Remove(orderToRemove);
                            Console.WriteLine("Order Removed Successfully");
                        }
                        else
                        {
                            Console.WriteLine("Order Id not found");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Show total number of orders");
                        int OrdersCount=0;
                        foreach(Foodie item in list)
                        {
                            OrdersCount++;
                        }
                        Console.WriteLine(OrdersCount);
                        break;
                    case 6:
                        Console.WriteLine("Sort the orders by amount ");
                        list.Sort(new OrdersComparer());
                        Console.WriteLine("orders Sorted by Money");

                        foreach(Foodie item in list)
                        {
                            Console.WriteLine($" Id:{item.orderId}\n Customername: {item.customerName}\n totalAmount: {item.totalAmount}");
                        }
                        break;
                    case 7:
                        list.Reverse();
                        Console.WriteLine("Orders in reverse Order. ");

                        foreach (Foodie item in list)
                        {
                            Console.WriteLine($" Id:{item.orderId}\n Customername: {item.customerName}\n totalAmount: {item.totalAmount}");
                        }
                        break;
                    case 8:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Entry");
                        break;
                }
                Console.ReadLine();
            }
        }
        public class OrdersComparer : IComparer
        {
            public int Compare(object x, object y)
            {
                return ((Foodie)x).totalAmount.CompareTo(((Foodie)y).totalAmount);
            }
        }
    }
}
