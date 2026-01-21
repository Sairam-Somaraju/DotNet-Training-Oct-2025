using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [RoutePrefix("api/Customers")]

    public class CustomersController : ApiController
    {
        NorthwindEntities1 db= new NorthwindEntities1 ();

        [HttpGet]
        [Route("getbyempid/{employeeId}")]
        public IHttpActionResult GetOrdersByEmployee(int employeeId)
        {
            var orders = db.Orders
                           .Where(o => o.EmployeeID == employeeId)
                           .Select(o => new
                           {
                               o.OrderID,
                               o.OrderDate,
                               o.CustomerID,
                               CustomerName = o.Customer.CompanyName,
                               ContactName = o.Customer.ContactName,
                               EmployeeName = o.Employee.FirstName + " " + o.Employee.LastName
                           })
                           .ToList();

            return Ok(orders);
        }
         
        [HttpGet]
        [Route("GetBycountry")]
        public IHttpActionResult GetCustomersByCountry(string country)
        {
            var customers = db.GetCustomersByCountry(country).ToList();
            return Ok(customers);
        }

    }
}
