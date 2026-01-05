using MVC_DatabaseFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
namespace MVC_DatabaseFirst.Controllers
{
    public class ProductController : Controller
    {
        NorthwindEntities db=new NorthwindEntities();
        // GET: Product
        public ActionResult Index()
        {
            //using eager loading by including supplier and category models along with product model
            var products = db.Products.Include(p1 => p1.Category).Include(p1 => p1.Supplier);
            return View(products.ToList());
        }

        //1. Add a Product 
        public ActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID","CategoryName");
            ViewBag.SupplierID = new SelectList(db.Suppliers, "SupplierID", "CompanyName");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            //for the category and supplier dropdowns
            ViewBag.Category = new SelectList(db.Categories, "CategoryID", "CategoryName",product.CategoryID);
            ViewBag.SupplierID = new SelectList(db.Suppliers, "SupplierID", "CompanyName",product.SupplierID);
            return View(product);
        }

        //To Edit
        public ActionResult Edit(int id)
        {
            Product product = db.Products.Find(id); //fetch product from database
            if (product == null)
            {
                return HttpNotFound();
            }

            ViewBag.CategoryID = new SelectList(db.Categories,"CategoryID","CategoryName",product.CategoryID);

            ViewBag.SupplierID = new SelectList(db.Suppliers,"SupplierID","CompanyName",product.SupplierID);

            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

             ViewBag.CategoryID = new SelectList(db.Categories,"CategoryID","CategoryName",product.CategoryID);

            ViewBag.SupplierID = new SelectList(db.Suppliers,"SupplierID","CompanyName",product.SupplierID
            );

            return View(product);
        }
        //To Delete
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
             Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

         
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var orderDetails = db.Order_Details.Where(o => o.ProductID == id).ToList();

            db.Order_Details.RemoveRange(orderDetails);

            Product product = db.Products.Find(id);
            db.Products.Remove(product);

            db.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}