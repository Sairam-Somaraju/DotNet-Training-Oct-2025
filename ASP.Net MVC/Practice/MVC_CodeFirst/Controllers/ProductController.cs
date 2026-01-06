using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using MVC_CodeFirst.Models;
using MVC_CodeFirst.Repository;

namespace MVC_CodeFirst.Controllers
{
    public class ProductController : Controller
    {
        IProductRepository<Product> _productRepo = null;

        //Contoller Constructor 
        public ProductController()
        {
            _productRepo=new ProductRepository<Product>();
        }

        // GET: Product
        //All Products
        public ActionResult Index()
        {
            var products= _productRepo.GetAll();
            return View(products);
        }
        public ActionResult Create()
        {
            return View();
        }
        //2.Creatingt a new
        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _productRepo.Insert(product);
                _productRepo.Save();
                return RedirectToAction("Index");
            }
            return  View(product);

        }

        //To Update
        public ActionResult Edit(int id)
        {
            var product = _productRepo.GetByID(id);
            
            return View(product);
        }

         [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _productRepo.Update(product);
                _productRepo.Save();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // To Delete
        public ActionResult Delete(int id)
        {
            var product = _productRepo.GetByID(id);
             
            return View(product);
        }

         [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var product = _productRepo.GetByID(id);
            _productRepo.Delete(id);
            _productRepo.Save();
            return RedirectToAction("Index");
        }

        //To Details
        public ActionResult Details(int id)
        {
            var product = _productRepo.GetByID(id);

            return View(product);
        }
        [HttpPost, ActionName("Details")]
        public ActionResult DetailsOfProduct(Product product)
        {
             _productRepo.Save();
            return RedirectToAction("Index");
        }

    }
}