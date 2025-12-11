using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_12_25
{
    internal class LinqDemo
    {
        static void Main(string[] args)
        {
            List<empdet> employees = new List<empdet>
            {
                new empdet { EmpId = 1, EmpName = "Aasritha", Salary = 30000, DateOfJoin = DateTime.Now.AddYears(-1), DeptId = 2 },
                new empdet { EmpId = 2, EmpName = "Akshay", Salary = 32000, DateOfJoin = DateTime.Now.AddYears(-2), DeptId = 2 },
                new empdet { EmpId = 3, EmpName = "Anvith Reddy", Salary = 35000, DateOfJoin = DateTime.Now.AddMonths(-10), DeptId = 3 },
                new empdet { EmpId = 4, EmpName = "ASHOK", Salary = 28000, DateOfJoin = DateTime.Now.AddYears(-1), DeptId = 1 },
                new empdet { EmpId = 5, EmpName = "Deepalakshmi", Salary = 36000, DateOfJoin = DateTime.Now.AddMonths(-6), DeptId = 4 },
                new empdet { EmpId = 6, EmpName = "Deepti", Salary = 36000, DateOfJoin = DateTime.Now.AddYears(-1), DeptId = 4 },
                new empdet { EmpId = 7, EmpName = "Dharani sri", Salary = 30000, DateOfJoin = DateTime.Now.AddYears(-3), DeptId = 1 },
                new empdet { EmpId = 8, EmpName = "Humera", Salary = 33000, DateOfJoin = DateTime.Now.AddMonths(-8), DeptId = 2 },
                new empdet { EmpId = 9, EmpName = "Kanishka", Salary = 31000, DateOfJoin = DateTime.Now.AddYears(-1), DeptId = 3 },
                new empdet { EmpId = 10, EmpName = "KEERTHANA", Salary = 30000, DateOfJoin = DateTime.Now.AddMonths(-4), DeptId = 4 },
                new empdet { EmpId = 11, EmpName = "Keerthi", Salary = 35000, DateOfJoin = DateTime.Now.AddMonths(-5), DeptId = 2 },
                new empdet { EmpId = 12, EmpName = "Keerthickragul", Salary = 36000, DateOfJoin = DateTime.Now.AddYears(-2), DeptId = 3 },
                new empdet { EmpId = 13, EmpName = "Logeshwaran", Salary = 28000, DateOfJoin = DateTime.Now.AddMonths(-9), DeptId = 1 },
                new empdet { EmpId = 14, EmpName = "Madavi", Salary = 30000, DateOfJoin = DateTime.Now.AddYears(-1), DeptId = 1 },
                new empdet { EmpId = 15, EmpName = "Manikanta", Salary = 31000, DateOfJoin = DateTime.Now.AddMonths(-7), DeptId = 2 },
                new empdet { EmpId = 16, EmpName = "Fatima", Salary = 29000, DateOfJoin = DateTime.Now.AddYears(-3), DeptId = 3 },
                new empdet { EmpId = 17, EmpName = "Nagamani", Salary = 35000, DateOfJoin = DateTime.Now.AddMonths(-6), DeptId = 2 },
                new empdet { EmpId = 18, EmpName = "Pooja", Salary = 30000, DateOfJoin = DateTime.Now.AddYears(-1), DeptId = 4 },
                new empdet { EmpId = 19, EmpName = "Hymavathi", Salary = 32000, DateOfJoin = DateTime.Now.AddYears(-2), DeptId = 1 },
                new empdet { EmpId = 20, EmpName = "Sairam Somaraju", Salary = 40000, DateOfJoin = DateTime.Now.AddMonths(-9), DeptId = 4 },
                new empdet { EmpId = 21, EmpName = "Sakthivel", Salary = 31000, DateOfJoin = DateTime.Now.AddMonths(-10), DeptId = 2 },
                new empdet { EmpId = 22, EmpName = "Usha sri", Salary = 29000, DateOfJoin = DateTime.Now.AddYears(-1), DeptId = 3 },
                new empdet { EmpId = 23, EmpName = "Waseef", Salary = 36000, DateOfJoin = DateTime.Now.AddMonths(-3), DeptId = 1 }
            };
         public void Demo1()
        {

            string[] studentnames = { "Ashritha", "deepa", "Ashok", "sai", "kanishka", "Anvith" };


            // show me all names starts with A

            var res = from t in studentnames
                      where t.StartsWith("A") || t.Length == 3
                      select t;

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }


        }
        public void Demo2()
        {

            int[] numbers = { 10, 11, 12, 13, 14, 15, 16 };

            // write a linq program to show only even number



            var res = from i in numbers
                      where i % 2 == 0 && i > 12
                      select i;



            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

        }
        public void Demo3()
        {

            // arrays, lists, xml, database ....

            //===================================================================
            //write a linq query to display all details where name contains a 'K' 

            var res = from t in employees
                      where t.EmpName.Contains("K")
                      select t;

            //===================================================================

            // write a linq query to display all empid between 8  23 and sort names in descending order


            / vr res = from t in employees where t.EmpId > 8 && t.EmpId <= 23 orderby t.EmpName descending select t;


            //===================================================================
            // write a linq query to show only empid , empname, deptid


            var res = from t in employees

                      select new { Employeeid = t.EmpId, Employeename = t.EmpName, departmentid = t.DeptId };


            foreach (var item in res)
            {
                Console.WriteLine($"{item.Employeeid}  {item.Employeename}   {item.departmentid}");
            }

            //===================================================================


            // how many rows are printed ?
            // 5 

            var res = (from t in employees
                       select t).ToList();   // this linq query is not executed here


            employees.Add(new empdet { EmpId = 9, EmpName = "Kanishka", Salary = 31000, DateOfJoin = DateTime.Now.AddYears(-1), DeptId = 3 });
            employees.Add(new empdet { EmpId = 20, EmpName = "Sairam Somaraju", Salary = 40000, DateOfJoin = DateTime.Now.AddMonths(-9), DeptId = 4 });


            foreach (var item in res)// linq query is executed here
            {
                Console.WriteLine($"{item.EmpId}  {item.EmpName}   {item.Salary}  {item.DateOfJoin}  {item.DeptId}");
            }

            //===================================================================

            List<dept> departments = new List<dept>
     {
         new dept { DeptId = 1, DeptName = "HR" },
         new dept { DeptId = 2, DeptName = "IT" },
         new dept { DeptId = 3, DeptName = "Finance" },
         new dept { DeptId = 4, DeptName = "Training" }
     };

            // show me common records from both the table

            //var res = from t in employees
            //          from t1 in departments
            //          where t.DeptId == t1.DeptId
            //          select new {t.EmpId, t.DeptId,t.EmpName, t.Salary , t1.DeptName };


            var res = from t in employees
                      join t1 in departments
                      on t.DeptId equals t1.DeptId
                      select new { t.EmpId, t.DeptId, t.EmpName, t.Salary, t1.DeptName };



            foreach (var item in res)// linq query is executed here
            {
                Console.WriteLine($"{item.EmpId}  {item.EmpName}   {item.Salary}  {item.DeptId}  {item.DeptName}");
            }


         };

        


        }

    }
}
    
}
