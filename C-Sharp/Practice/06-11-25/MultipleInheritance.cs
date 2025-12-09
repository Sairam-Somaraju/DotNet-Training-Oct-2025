using System;

namespace _06_11_2025
{
    interface IProduct
    {
        void GetProductInfo();
        void DisplayProductInfo();
    }

    interface IReview
    {
        void GetReviews();
        void DisplayReviews();
    }

    public class customer : IProduct, IReview
    {
        int ProductId { get; set; }
        string ProductName { get; set; }
        string Price { get; set; }
        public static int ReviewId { get; set; } = 0;
        public string Comments { get; set; }
        public int Ratings { get; set; }
        public int CustomerProductId { get; set; }

        // ✅ Corrected method name
        public void GetProductInfo()
        {
            Console.WriteLine("Enter the ProductId, Name, Price:");
            ProductId = Convert.ToInt32(Console.ReadLine());
            ProductName = Console.ReadLine();
            Price = Console.ReadLine();
        }

        public void DisplayProductInfo()
        {
            Console.WriteLine("\n=== Product Details ===");
            Console.WriteLine("ProductId: " + ProductId);
            Console.WriteLine("ProductName: " + ProductName);
            Console.WriteLine("Price: " + Price);
        }

        public void GetReviews()
        {
            Console.WriteLine("\nEnter the ProductId, Comments, Rating (1-5):");
            ProductId = Convert.ToInt32(Console.ReadLine());
            Comments = Console.ReadLine();
            Ratings = Convert.ToInt32(Console.ReadLine());
            ReviewId++;
        }

        public void DisplayReviews()
        {
            Console.WriteLine("\n=== Review Details ===");
            Console.WriteLine("ReviewId: " + ReviewId);
            Console.WriteLine("ProductId: " + ProductId);
            Console.WriteLine("Comments: " + Comments);
            Console.WriteLine("Ratings: " + Ratings);
        }
    }

    internal class MultipleInheritance
    {
        public static void Main(string[] args)
        {
            customer customer = new customer();
            customer.GetProductInfo();   
            customer.GetReviews();

            Console.WriteLine("\nProduct Details and Customer Reviews\n------------------------------------");
            customer.DisplayProductInfo();
            customer.DisplayReviews();
        }
    }
}
