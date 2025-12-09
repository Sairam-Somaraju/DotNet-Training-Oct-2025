using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_11_25
{

    public interface IOrder
    {
        string Id { get; }
        string BuyerEmail { get; }
        string ShipToCity { get; }
        double TotalWeightKg { get; }
        List<ILineItem> Items { get; }
        string Status { get; set; }
    }
    public interface ILineItem
    {
        string ProductName { get; }
        int Quantity { get; }
        double Price { get; }
    }
    public interface IPricingStrategy
    {
        double CalculateTotal(List<ILineItem> items);
    }

    public interface IPaymentProvider
    {
        void Authorize(IOrder order);
        void Capture(IOrder order);
    }

    public interface IShipmentQuoter
    {
        double GetQuote(IOrder order);
    }

    public interface INotifier
    {
        void Notify(string message);
    }
    public class LineItem : ILineItem
    {
        public string ProductName { get; }
        public int Quantity { get; }
        public double Price { get; }

        public LineItem(string name, int qty, double price)
        {
            ProductName = name;
            Quantity = qty;
            Price = price;
        }
    }
    public class Order : IOrder
    {
        public string Id { get; }
        public string BuyerEmail { get; }
        public string ShipToCity { get; }
        public double TotalWeightKg { get; }
        public List<ILineItem> Items { get; }
        public string Status { get; set; }

        public Order(string id, string email, string city, double weight, List<ILineItem> items)
        {
            Id = id;
            BuyerEmail = email;
            ShipToCity = city;
            TotalWeightKg = weight;
            Items = items;
            Status = "Created";
        }
    }
    public class MRPStrategy : IPricingStrategy
    {
        public double CalculateTotal(List<ILineItem> items)
        {
            double total = 0;
            foreach (var i in items)
                total += i.Price * i.Quantity;
            return total;
        }
    }
    public class TieredDiscountStrategy : IPricingStrategy
    {
        public double CalculateTotal(List<ILineItem> items)
        {
            double total = 0;
            foreach (var i in items)
                total += i.Price * i.Quantity;

            if (total >= 15000)
                total *= 0.88; 
            else if (total >= 5000)
                total *= 0.95;  

            return total;
        }
    }

    internal class E_COMMERCESYSTEM
    {
        public static void Main(String[] args)
        {

        }
    }
}
