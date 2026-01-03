using First_MVC.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace First_MVC.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        //1. Noram Method
        public string NormalMethod()
        {
            return "Hii All... Welcome to MVC ";
        }
        //2.ViewResult
        public ViewResult ViewMethod()
        {
            return View();
        }

        //3.Content Result
        public ContentResult ContentMethod()
        {
            // return Content("HelloAll !! this is the content","text/plain");
            return Content("<h1 style=color:blue;>Good Evening to all </h1>");
        }

        //4.EmptyResult
        public EmptyResult EmptyMethod()
        {
            int amt = 45000;
            float si = (amt * 3 * 2) / 100;
            return new EmptyResult();
        }

        //5.Redirect
        public ActionResult redirectMethod()
        {
           // return RedirectToAction("NormalMethod");// redirectingb to other action method of the same controller 

           return RedirectToAction("index", "home");//// redirectingb to other action method of the different  controller 
        }
        public JsonResult JsonMethod()
        {
            Employee emp = new Employee() { Id = 101, Name = "Sairam", Age = 22 };

            return Json(emp,JsonRequestBehavior.AllowGet);
        }

        //to check if the tempdata values are available here from the previous controller multiple requests
        public ActionResult Test_TempData_across_controllers()
        {
            TempData.Keep();
            return View(TempData["fruit"]);
        }


        //this action method is to test the tempdata values being made
        //available even after traversing many requests, and without redirection
        public ActionResult CheckTempdata()
        {
            TempData.Keep();
            return View(TempData["stores"]);
        }
    }
            
}