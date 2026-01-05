using MVC_DatabaseFirst;
using MVC_DatabaseFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace MVC_DatabaseFirst.Controllers
{
    //Infinite2025Entities1 db = new Infinite2025Entities1();

    public class NavigationController : Controller
    {
        Infinite2025Entities1 db = new Infinite2025Entities1();

        // GET: Navigation
        public ActionResult Index()
        {
            return View();
        }
        //1.Fetching data from multiple tables/objects   using navigation property
        public ActionResult MultipleData()
        {
             return View(db.Products.ToList());
        }
    }
}