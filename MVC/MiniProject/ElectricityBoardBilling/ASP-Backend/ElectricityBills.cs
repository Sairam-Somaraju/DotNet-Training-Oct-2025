using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectricityBoardBilling.ASP_Backend
{
    public class ElectricityBills
    {
        public string ConsumerNumber { get; set; }
        public string ConsumerName { get; set; }
        public int UnitsConsumed { get; set; }
        public double BillAmount { get; set; }

        public ElectricityBills(string cno,string name,int units)
        {
              
            cno=cno.Trim();
            if (!cno.StartsWith("EB") || cno.Length != 7)
            {
                throw new FormatException("Invalid Consumer Number");
            }

            ConsumerNumber = cno;
            ConsumerName = name;
            UnitsConsumed = units;  
        }
    }
}