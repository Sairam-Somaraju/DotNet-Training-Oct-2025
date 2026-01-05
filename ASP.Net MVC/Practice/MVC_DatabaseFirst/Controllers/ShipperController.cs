using Microsoft.Ajax.Utilities;
using MVC_DatabaseFirst.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
namespace MVC_DatabaseFirst.Controllers
{
    public class ShipperController : Controller
    {
        NorthwindEntities db1=new NorthwindEntities();
        Infinite2025Entities1 db=new Infinite2025Entities1();
        // GET: Shipper
        public ActionResult Index()
        {
            return View(db.Departments.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        //1. Passing Data from View to Controller using form collection
        //public ActionResult Create(FormCollection frm)
        //{

        //    Orders2 o = new Orders2();
        //    o.order_id = Convert.ToInt32(frm["order_id"]);
        //    o.customer_id = Convert.ToInt32(frm["customer_id"]);
        //    o.order_date = Convert.ToDateTime(frm["order_date"]);
        //    o.price = Convert.ToInt32(frm["price"]);
        //    o.quantity = Convert.ToInt32(frm["order_id"]);
        //    o.product_name = frm["product_name"].ToString();
        //    o.total_amount = Convert.ToInt32(frm["total_amount"]);
        //    db.Orders2.Add(o);
        //    db.SaveChanges();

        //    return RedirectToAction("Index");

        //}



        //2.Passing data from  view to controller using parameter collection
        //.Parameters names to match attribute names 
        //[ActionName("Create")]
        //public ActionResult CreatePost( string name)
        //{
        //     Department dp=new Department();
        //   // dp.DeptId = id;
        //    dp.DeptName = name;
        //    db.Departments.Add(dp);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}



        //3. passing data from view to controller using request object
        [ActionName("Create")]
        public ActionResult CreatePost()
        {
            Department dep = new Department();
            dep.DeptId = Convert.ToInt32(Request["DeptId"]);
            dep.DeptName=Request["DeptName"];
            db.Departments.Add(dep);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        //4.calling stored procedures

        public ActionResult Sp_with_Parameters()
        {
            return View(db1.CustOrdersOrders("vinet"));
        }

    }
}