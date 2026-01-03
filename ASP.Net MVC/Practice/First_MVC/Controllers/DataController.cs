using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace First_MVC.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        public ActionResult Index()
        {
            //1. passing  an object that will be used as a model to the view 
            //ViewBag.data = "Flowers List";
            //List<string> flowers = new List<string>()
            //{
            //    "Roses","Lillies","Jasmine","Marigolds"
            //};
            //return View(flowers);


            //trying to acces  tempdata of the earlier few requests
            List<string> stlist = TempData["fruit"] as List<string>;
            //    return View(stlist); able to see tempdata from previous many requests

            //redirecting to see  termpdata values in different controller

             return RedirectToAction("Test_TempData_across_controllers", "Demo");


        }


        //2. Checking if the viewbag can pass on tha data/info to further requests
        public ActionResult TestDataTransfer()
        {
            ViewBag.data1 = "Data One";
            ViewData["data2"] = "Data two";
            // return View(); //data passed to the current view 

            return RedirectToAction("Index");
        }

        //3. Passing data throw viewbag and viewdata

        public ActionResult OfficeRules()
        {
            List<string> rules = new List<string>()
            {
                "Be on time","Carry your ID card","Complete work as per deadlines","Avoid T-Shirts"
            };
            //3.1 transfer data throw viewbag
            ViewBag.offrules = rules;
            //return View();

            //3.2 Transfer using viewdata
            ViewData["or"] = rules;
            //  return View();
            return RedirectToAction("TestDataTransfer");

        }

        //4.Passing data throw tempdata object
        public ActionResult FirstTempRequest()
        {
            List<string> fruits = new List<string>()
            {
                "Apple","Orange","Grapes","Banana","Pinapple"
            };

            TempData["fruit"] = fruits;

            //4.1 using tempdata in the current view
            // return View();

            //4.2 redirecting to see if tempdata is available
            return RedirectToAction("SecondTempRequest");
        }

        public ActionResult SecondTempRequest()
        {
            //List<String> stnlist;
            //stnlist = TempData["fruit"] as List<String>;
            //return View(stnlist);
            return RedirectToAction("Index"); // making a third request to index view 
        }
    }
}