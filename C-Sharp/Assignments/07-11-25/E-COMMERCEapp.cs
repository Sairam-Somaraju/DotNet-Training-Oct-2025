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

        // ===============================
        // DOMAIN CLASSES
        // ===============================
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

        // ===============================
        // PRICING STRATEGIES
        // ===============================
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
                    total *= 0.88; // 12% off
                else if (total >= 5000)
                    total *= 0.95; // 5% off

                return total;
            }
        }

        // ===============================
        // PAYMENT PROVIDERS (SEALED)
        // ===============================
        public abstract class PaymentProviderBase : IPaymentProvider
        {
            protected bool isCaptured = false;
            public abstract void Authorize(IOrder order);
            public abstract void Capture(IOrder order);
        }

        public sealed class RazorpayProvider : PaymentProviderBase
        {
            public override void Authorize(IOrder order)
            {
                Console.WriteLine($"Razorpay: Payment authorized for Order {order.Id}");
                order.Status = "Authorized";
            }

            public override void Capture(IOrder order)
            {
                if (isCaptured)
                    throw new Exception("Payment already captured!");
                Console.WriteLine($"Razorpay: Payment captured for Order {order.Id}");
                isCaptured = true;
                order.Status = "Captured";
            }
        }

        public sealed class StripeProvider : PaymentProviderBase
        {
            public override void Authorize(IOrder order)
            {
                Console.WriteLine($"Stripe: Payment authorized for Order {order.Id}");
                order.Status = "Authorized";
            }

            public override void Capture(IOrder order)
            {
                if (isCaptured)
                    throw new Exception("Payment already captured!");
                Console.WriteLine($"Stripe: Payment captured for Order {order.Id}");
                isCaptured = true;
                order.Status = "Captured";
            }
        }

        // ===============================
        // SHIPPING (SEALED)
        // ===============================
        public abstract class ShipmentQuoterBase : IShipmentQuoter
        {
            public abstract double GetQuote(IOrder order);
        }

        public sealed class BluedartQuoter : ShipmentQuoterBase
        {
            public override double GetQuote(IOrder order)
            {
                double cost = 60 + 25 * order.TotalWeightKg;
                if (order.ShipToCity.ToLower() == "mumbai")
                    cost *= 0.9; // 10% metro discount
                return cost;
            }
        }

        public sealed class DelhiveryQuoter : ShipmentQuoterBase
        {
            public override double GetQuote(IOrder order)
            {
                double cost = 50 + 28 * order.TotalWeightKg;
                if (order.ShipToCity.ToLower() == "remote")
                    cost *= 1.08; // 8% surcharge
                return cost;
            }
        }

        // ===============================
        // NOTIFICATIONS
        // ===============================
        public class EmailNotifier : INotifier
        {
            public void Notify(string message)
            {
                Console.WriteLine($"[EMAIL] {message}");
            }
        }

        public class SmsNotifier : INotifier
        {
            public void Notify(string message)
            {
                Console.WriteLine($"[SMS] {message}");
            }
        }

        // ===============================
        // ABSTRACT PROCESSOR
        // ===============================
        public abstract class OrderProcessorBase
        {
            public void ProcessOrder(IOrder order)
            {
                Validate(order);
                double total = Price(order);
                AuthorizePayment(order);
                QuoteShipment(order);
                CapturePayment(order);
                CreateShipment(order);
                SendNotifications(order, total);
                Persist(order);
            }

            protected virtual void Validate(IOrder order)
            {
                foreach (var i in order.Items)
                {
                    if (i.Quantity <= 0 || i.Price <= 0)
                        throw new Exception("Invalid item quantity or price!");
                }
                Console.WriteLine("Validation completed.");
            }

            protected abstract double Price(IOrder order);
            protected abstract void AuthorizePayment(IOrder order);
            protected abstract void CapturePayment(IOrder order);
            protected abstract void QuoteShipment(IOrder order);
            protected abstract void CreateShipment(IOrder order);
            protected abstract void SendNotifications(IOrder order, double total);

            protected internal virtual void Persist(IOrder order)
            {
                Console.WriteLine($"Order {order.Id} saved successfully to database.");
            }
        }

        // ===============================
        // SIMPLE ORDER PROCESSOR
        // ===============================
        public class SimpleOrderProcessor : OrderProcessorBase
        {
            private readonly IPricingStrategy pricing;
            private readonly IPaymentProvider payment;
            private readonly IShipmentQuoter quoter;
            private readonly List<INotifier> notifiers;

            public SimpleOrderProcessor(IPricingStrategy p, IPaymentProvider pay, IShipmentQuoter q, List<INotifier> n)
            {
                pricing = p;
                payment = pay;
                quoter = q;
                notifiers = n;
            }

            protected override double Price(IOrder order)
            {
                double total = pricing.CalculateTotal(order.Items);
                Console.WriteLine($"Order total: ₹{total}");
                return total;
            }

            protected override void AuthorizePayment(IOrder order)
            {
                payment.Authorize(order);
            }

            protected override void CapturePayment(IOrder order)
            {
                payment.Capture(order);
            }

            protected override void QuoteShipment(IOrder order)
            {
                double quote = quoter.GetQuote(order);
                Console.WriteLine($"Shipment quote: ₹{quote}");
            }

            protected override void CreateShipment(IOrder order)
            {
                order.Status = "Shipped";
                Console.WriteLine($"Shipment created for Order {order.Id}");
            }

            protected override void SendNotifications(IOrder order, double total)
            {
                foreach (var n in notifiers)
                {
                    n.Notify($"Order {order.Id} processed successfully. Total: ₹{total}");
                }
            }
        }

        // ===============================
        // MAIN PROGRAM
        // ===============================
        internal class Program
        {
            static void Main()
            {
                List<ILineItem> items = new List<ILineItem>
            {
                new LineItem("Laptop", 1, 50000),
                new LineItem("Mouse", 2, 800)
            };

                IOrder order = new Order("ORD1001", "john@example.com", "Mumbai", 3.5, items);

                IPricingStrategy pricing = new TieredDiscountStrategy();
                IPaymentProvider payment = new RazorpayProvider();
                IShipmentQuoter quoter = new BluedartQuoter();
                List<INotifier> notifiers = new List<INotifier> { new EmailNotifier(), new SmsNotifier() };

                SimpleOrderProcessor processor = new SimpleOrderProcessor(pricing, payment, quoter, notifiers);

                Console.WriteLine("\n=== Starting Order Processing ===");
                processor.ProcessOrder(order);
                Console.WriteLine("=== Order Completed Successfully ===");
            }
        }
    }


