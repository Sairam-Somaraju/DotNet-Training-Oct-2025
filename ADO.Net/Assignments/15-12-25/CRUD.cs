using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    public  class CRUD
    {
        Model1 dc=new Model1();

        public void insertnewEmployees()
        {
            try
            {
                Console.WriteLine("enter employee Id");
                string Id = Console.ReadLine();
                Console.WriteLine("Enter Employee Name");
                string Ename = Console.ReadLine();
                Console.WriteLine("Enter Employee DeptName");
                string Dname = Console.ReadLine();
                Console.WriteLine("Enter Employee salary");
                int sal = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee joining year");
                int Jyear = int.Parse(Console.ReadLine());
                Employee e = new Employee()
                {
                    Empid = Id,
                    EmpName = Ename,
                    DepartmentName = Dname,
                    Salary = sal,
                    YearOfJoining = Jyear

                };
                dc.Employees.Add(e);
                int re = dc.SaveChanges();
                Console.WriteLine("Total record inserted is: " + re);
            }
            catch (Exception ex)
            {
                var res = dc.GetValidationErrors();
                foreach (var err in res)
                {
                    if (err.ValidationErrors.Count > 0)
                    {
                        foreach (var error in err.ValidationErrors)
                        {
                            Console.WriteLine(error);
                        }
                    }
                }
            }
        }
        public void ShowAllEmployees()
        {
            try
            {
                var employees = dc.Employees.ToList();

                foreach (var e in employees)
                {
                    Console.WriteLine($"{e.Empid} {e.EmpName} {e.DepartmentName} {e.Salary}");
                }
            }
            catch (Exception ex)
            {
                var res = dc.GetValidationErrors();
                foreach (var err in res)
                {
                    if (err.ValidationErrors.Count > 0)
                    {
                        foreach (var error in err.ValidationErrors)
                        {
                            Console.WriteLine(error);
                        }
                    }
                }
            }

        }

        public void UpdateEmployee()
        {
            try
            {
                Console.WriteLine("Enter employeeid");
                string Id = Console.ReadLine();
                Console.WriteLine("Enter new salary");
                int sal = int.Parse(Console.ReadLine());

                var emp = dc.Employees.Where(e => e.Empid == Id).FirstOrDefault();
                
                    emp.Salary = sal;
                    dc.SaveChanges();
                    Console.WriteLine("Employee Salary Updated");
                
            }
            catch (Exception ex)
            {
                var res = dc.GetValidationErrors();
                foreach (var err in res)
                {
                    if (err.ValidationErrors.Count > 0)
                    {
                        foreach (var error in err.ValidationErrors)
                        {
                            Console.WriteLine(error);
                        }
                    }
                }
            }

        }
        public void DeleteEmployeeRecord()
        {
            try
            {
                Console.WriteLine("Enter Employee id for removing record");
                string Id = Console.ReadLine();

                var emp = dc.Employees.Where(e => e.Empid == Id).First();
                
                    dc.Employees.Remove(emp);
                    dc.SaveChanges();
                    Console.WriteLine("Employee deleted");
                
            }
            catch (Exception ex)
            {

                var res = dc.GetValidationErrors();
                foreach (var err in res)
                {
                    if (err.ValidationErrors.Count > 0)
                    {
                        foreach (var error in err.ValidationErrors)
                        {
                            Console.WriteLine(error);
                        }
                    }
                }
            }
        }
    }
}
