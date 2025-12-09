using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_11_2025
{
    class InterestCalculater
    {
        public double calculateInterest(double PrincipleAmount, double rate)
        {
            double simpleInterest = (PrincipleAmount * rate * 12) / 100;
            return simpleInterest;
        }
        public double calculateInterest(double PrincipleAmount, double rate, double time)
        {
            double simpleInterest = (PrincipleAmount * rate * time) / 100;
            return simpleInterest;
        }
        //public double calculateInterest(double PrincipalAmount, double rate, double time, bool isCompound)
        //{

        //}
    }
    internal class CalculateInterest
    {
        static void Main(string[] args)
        {
             InterestCalculater interestCalculater = new InterestCalculater();
             Console.WriteLine("Simple Interest: "+interestCalculater.calculateInterest(100000, 2));
            Console.WriteLine("Simple Interest with time according to me: " + interestCalculater.calculateInterest(50000, 3, 24));
         }
    }
}
