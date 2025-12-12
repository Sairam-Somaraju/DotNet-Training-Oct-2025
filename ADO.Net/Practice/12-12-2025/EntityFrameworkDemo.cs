using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_12_2025
{
    internal class EntityFrameworkDemo
    {
        ADOnetEntities1 ado=new ADOnetEntities1();

        public void showallEmployees()
        {
            var res = from t in ado.Employees
                      select t;
            foreach (var e in res)
            {
                Console.WriteLine($"{e.EmpID} {e.EmpName} {e.DateOfJoin} {e.Salary} {e.DeptID}");
                Console.WriteLine("==========================================");
            }
        }
        public void SearchRecord()
        {
            Console.WriteLine("Enter the name: ");
            string name=Console.ReadLine();
            var res=from t in ado.Employees
                    where t.EmpName.Contains(name)
                    select t;

            foreach(var e in res)
            {
                Console.WriteLine($"{e.EmpID} {e.EmpName} {e.DateOfJoin} {e.Salary} {e.DeptID}");
                Console.WriteLine("================================================================");
            }
        }
        public void AddRecord()
        {
            Employee emp = new Employee() { EmpName = "Paddu", Salary = 80000, DateOfJoin = DateTime.Parse("01-01-2000"), DeptID = 10 };
           ado.Employees.Add(emp);

            int i= ado.SaveChanges();
            Console.WriteLine("total rows inserted: "+i);

        }

        public void DeleteRecord()
        {
            Console.WriteLine("ENter the id to delete record: ");
            int id=int.Parse(Console.ReadLine());

            var res= (from t in ado.Employees
                     where t.EmpID==id
                     select t).First();
            ado.Employees.Remove(res);

            int i=ado.SaveChanges();
            Console.WriteLine("Total rows deleted: "+i);
        }

        public void UpdateRecord()
        {
            Console.WriteLine("ENter the id to delete record: ");
            int id = int.Parse(Console.ReadLine());
            var res=( from t in ado.Employees
                     where t.EmpID==id
                     select t).First();

            res.Salary = 75000;
            int i=ado.SaveChanges();
            Console.WriteLine("Updated the record");
        }

    }
}
