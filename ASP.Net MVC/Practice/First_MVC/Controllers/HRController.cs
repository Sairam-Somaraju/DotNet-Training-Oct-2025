using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using First_MVC.Models;
namespace First_MVC.Controllers
{
    public class HRController : Controller
    {
        // GET: HR
        //3.calling another view and passing the model object
        public ActionResult Index()
        {
            List<Department> departments = new List<Department>()
            {
                new Department{Id=1,Name="ECE"},
                new Department{Id=2,Name="CSE"},
                new Department{Id=3,Name="BSC"},
                new Department{Id=4,Name="MSC"}
            };  
            return View("DepartmentList",departments);
        }

        //the receiving view
        public ActionResult DepartmentList(List<Department> d)
        {
            return View(d);
        }

        //1.Binding a model object to a view
        public ActionResult DisplayEmployee()
        {
              Employee employee = new Employee() { Id=1,Name="Sairam",Age=24};
              return View(employee); //passing a model object of type Employe


        }
        //2. Binding a collection moel object to a view
        public ActionResult EmployeeList()
        {
            List<Employee> empList = new List<Employee>()
            {
                new Employee { Id = 10, Name = "Sairam", Age = 21 },
                new Employee { Id = 11, Name = "Manikanta", Age = 22 },
                new Employee { Id = 12, Name = "Akshay", Age = 23 },
                new Employee { Id = 13, Name = "Ragul", Age = 23 }

            };
            return View(empList);
        }

    }
}