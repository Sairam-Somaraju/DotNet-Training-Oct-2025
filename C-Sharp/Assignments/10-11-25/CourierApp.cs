using System;


namespace _10_11_2025
{
    public abstract class ShippingCalculator
    {
        public abstract decimal Calculate(decimal weight, string zone);
        public virtual string Label() => "Generic Shipping Service";
    }

    public class StandardShipping : ShippingCalculator
    {
        public override decimal Calculate(decimal weight, string zone)
        {
            decimal Rate = 10.00m;
            decimal perKg;

            switch (zone)
            {
                case "A":
                    perKg = 1.00m;
                    break;
                case "B":
                    perKg = 1.50m;
                    break;
                default:
                    perKg = 2.00m;
                    break;
            }

            return Rate + (perKg * weight);
        }

        public override string Label() => "Standard Shipping (3–5 business days)";
    }

    public class ExpressShipping : ShippingCalculator
    {
        public override decimal Calculate(decimal weight, string zone)
        {
            decimal Rate = 20.00m;
            decimal perKg;

            switch (zone)
            {
                case "A":
                    perKg = 2.50m;
                    break;
                case "B":
                    perKg = 3.00m;
                    break;
                default:
                    perKg = 3.50m;
                    break;
            }

            return Rate + (perKg * weight);
        }

        public override string Label() => "Express Shipping (1–2 business days)";
    }

    public class InternationalShipping : ShippingCalculator
    {
        public override decimal Calculate(decimal weight, string zone)
        {
            decimal ratePerKg;
            decimal zones;

            if (weight <= 2)
                ratePerKg = 15.00m;
            else if (weight <= 5)
                ratePerKg = 12.00m;
            else
                ratePerKg = 10.00m;

            switch (zone)
            {
                case "singapore":
                    zones = 1.0m;
                    break;
                case "china":
                    zones = 1.2m;
                    break;
                case "us":
                    zones = 1.5m;
                    break;
                default:
                    zones = 2.0m;
                    break;
            }

            return (ratePerKg * weight) * zones;
        }

        public override string Label() => "International Shipping (5–10 business days)";

    }

    internal class CourierApp
    {
        static void Main(string[] args)
        {
            ShippingCalculator[] calculators =
            {
                new StandardShipping(),
                new ExpressShipping(),
                new InternationalShipping()
            };

            decimal weight = 3.5m;
            string zone = "B";

            foreach (var calc in calculators)
            {
                Console.WriteLine(calc.Label());
                Console.WriteLine($"Zone: {zone}, Weight: {weight} kg");
                Console.WriteLine($"Cost: {calc.Calculate(weight, zone):C}");
            }

            Console.ReadLine();
        }
    }
}



