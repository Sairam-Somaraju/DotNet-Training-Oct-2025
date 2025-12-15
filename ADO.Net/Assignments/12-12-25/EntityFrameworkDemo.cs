using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_12_25
{
    internal class EntityFrameworkDemo
    {
        ADOnetEntities1  ado=new ADOnetEntities1();
        //Task-1
        public void MatchingRecords()
        {
            var res = from e in ado.Employees
                      join d in ado.Departments
                      on e.DeptID equals d.DeptID
                      select new
                      {
                          EmpName = e.EmpName,
                          DepName = d.DeptName
                      };
            foreach (var x in res)
            {
                Console.WriteLine($"{x.EmpName}   {x.DepName}");
            }
        }
        //Task-2
        public void displayDetails()
        {
            var res = from e in ado.Employees
                      join d in ado.Departments
                      on e.DeptID equals d.DeptID
                      select new
                      {
                          empid=e.EmpID,
                          empname=e.EmpName,
                          deptid=e.DeptID,
                          salary=e.Salary,
                      };
            foreach( var x in res)
            {
                Console.WriteLine($" {x.empid}    {x.empname}    {x.deptid}  ");

            }


        }
        //Task-3
        public void DisplaybyDate()
        {
            Console.WriteLine("Enter start date: ");
             string input=Console.ReadLine();
            DateTime startdate = DateTime.Parse(input);

            Console.WriteLine("Enter end date: ");
            string input1 = Console.ReadLine();
            DateTime enddate = DateTime.Parse(input1);

            var res = from e in ado.Employees
                      where e.DateOfJoin >= startdate && e.DateOfJoin <= enddate
                      select e;
            foreach (var x in res)
            {
                Console.WriteLine($" {x.EmpID}    {x.EmpName}    {x.DateOfJoin}   {x.DeptID} ");

            }
        }
        //Task-4
        public void SalaryWithBonus()
        {
            var res = from e in ado.Employees
                      select new
                      {
                          empId = e.EmpID,
                          Empname =e.EmpName,
                          Salary=e.Salary+(e.Salary*30/100)


                      };
            foreach ( var x in res)
            {
                Console.WriteLine($"{x.empId}  {x.Empname}   {x.Salary}");
            }
        }
        //Task-5
        public void InsertUpdate()
        {
            Console.WriteLine("Enter the Id to Update: ");
            int id = int.Parse(Console.ReadLine());

            var res = (from e in ado.Employees
                       where e.EmpID == id
                       select e).FirstOrDefault();

            if (res != null)
            {
                res.EmpName = "Vinnu";
                res.Salary = 80000;
                res.DateOfJoin = DateTime.Parse("01-01-2000" );

                // Use only a valid DeptID that exists in Departments table
                res.DeptID = 10;
            }
            else
            {
                // Insert new employee
                Employee emp = new Employee()
                {
                    EmpName = "Vinnu",
                    Salary = 80000,
                    DateOfJoin = DateTime.Parse("01-01-2000" ),
                    DeptID = 10 // existing DeptID
                };
                ado.Employees.Add(emp);
            }

            int i = ado.SaveChanges();
            Console.WriteLine("Total records affected: " + i);
        }


        //Task-6
        public void RecordDelete()
        {
            Console.WriteLine("Enter the Id to Update: ");
            int id = int.Parse(Console.ReadLine());

            var res = (from e in ado.Employees
                      where e.EmpID == id
                      select e).First();
            ado.Employees.Remove(res);
            int i=ado.SaveChanges();
            Console.WriteLine("Total Records Deleted:  " + i);
        }
         
    }
}
