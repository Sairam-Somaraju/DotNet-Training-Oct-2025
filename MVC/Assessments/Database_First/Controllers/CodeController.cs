using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Database_First.Models;
namespace Database_First.Controllers
{
    public class CodeController : Controller
    {
        // GET: Code
        //public ActionResult Index()
        //{
        //    return View();
        //}

        private NorthwindEntities db = new NorthwindEntities();

        // To Return all customers residing in Germany
        public ActionResult CustomersInGermany()
        {
            var Customers = db.Customers.Where(customers => customers.Country == "Germany").ToList();
            return View(Customers);
        }

        // To Return customer details with orderId == 10248
        public ActionResult CustomerOrder()
        {
            var customerDetails = db.Orders
                                     .Where(order => order.OrderID == 10248)
                                     .Select(order => order.Customer)
                                     .FirstOrDefault();
            return View(customerDetails);
        }

    }
}