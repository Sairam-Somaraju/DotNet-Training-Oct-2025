using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_11_25
{
    internal class Vehicle
    {
        public string Type;
        public decimal BaseFare;
        public decimal PerKmRate;

        public Vehicle(string type, decimal baseFare, decimal perKmRate)
        {
            Type = type;
            BaseFare = baseFare;
            PerKmRate = perKmRate;
        }
    }
}
