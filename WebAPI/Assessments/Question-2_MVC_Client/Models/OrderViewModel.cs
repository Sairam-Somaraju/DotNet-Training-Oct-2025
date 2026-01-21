using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Client.Models
{
    public class OrderViewModel
    {
        public int OrderID { get; set; }
        public DateTime? OrderDate { get; set; }
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string ContactName { get; set; }
        public string EmployeeName { get; set; }
    }
}