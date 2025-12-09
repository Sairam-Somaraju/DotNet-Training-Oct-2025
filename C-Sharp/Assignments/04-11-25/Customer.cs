using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_11_25
{
    internal class Customer
    {

        public string Name;
        public int LoyaltyPoints;

        public Customer(string name, int loyaltyPoints)
        {
            Name = name;
            LoyaltyPoints = loyaltyPoints;
        }
    }
}
