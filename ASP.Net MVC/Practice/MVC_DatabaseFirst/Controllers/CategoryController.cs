using Microsoft.Ajax.Utilities;
using MVC_DatabaseFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace MVC_DatabaseFirst.Controllers
{
    public class CategoryController : Controller
    {
        Infinite2025Entities1 db = new Infinite2025Entities1();
        // GET: Category
        public ActionResult Index()
        {
            //1. The below action method uses scaffolded view  
            List<Customer2> cust = db.Customer2.ToList();
            return View(cust);
        }

        //2.The below action method does not use scaffolded view

        public ActionResult GetCategoryDetails()
        {
            List<Customer2> cust = db.Customer2.ToList();
            return View(cust);
        }

        //3.Adding or interesting a new category
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer2 cust) //Passing data from view to create
        {
            db.Customer2.Add(cust);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            Customer2 cust = db.Customer2.Find(id);
            return View(cust);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteCategory(int id)
        {
            Customer2 customer = db.Customer2.Find(id);
            db.Customer2.Remove(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //to update
        public ActionResult Edit(int id)
        {
            Customer2 cust = db.Customer2.Find(id);
            return View(cust);
        }
        [HttpPost, ActionName("Edit")]
        public ActionResult Editcatogory(Customer2 custt)
        {
              db.Customer2.AddOrUpdate(custt);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //sorting catogiry by name

        public ActionResult GetCategoryByName()
        {
            List<string> sortedlist = (from c in db.Customer2
                                       orderby c.customerName
                                       select c.customerName).ToList();
                        return View(sortedlist);
        }
    }
}