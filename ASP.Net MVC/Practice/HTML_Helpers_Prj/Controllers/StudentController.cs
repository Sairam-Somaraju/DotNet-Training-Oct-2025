using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HTML_Helpers_Prj.Models;
using Microsoft.Ajax.Utilities;
namespace HTML_Helpers_Prj.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        //1. Stronglytyped Helper
        public ActionResult Strongly_Typed_Helper()
        {
            return View();
        }

        //2. Template helper individual
        public ActionResult TemplatedHelper_ind()
        {
            return View();
        }

        //3.Templated helper for the entire model (Editor Template)
        public ActionResult TemplateForModel()
        {
            return View();
        }

        //4. Display template
        public ActionResult StudentDisplay()
        {
            Student student = new Student()
            {
                RNO = 10,
                Name="Rahul",
                Address="Chennai",
            };
            ViewData["stddata"] = student;
            return View(student);
        }

        //5.Standard Helper
        public ActionResult Standard_Helper()
        {
            return View();
        }
    }
}