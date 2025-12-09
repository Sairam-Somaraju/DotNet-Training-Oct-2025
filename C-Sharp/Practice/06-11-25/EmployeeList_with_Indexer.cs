using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_11_2025
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EMployeeName { get; set; }
        public string Gender { get; set; }
    }
    internal class EmployeeList_with_Indexer
    {
        List<Employee> employeelist=new List<Employee>()
        { new Employee() {EmployeeId = 1, EMployeeName="sairam", Gender="male"}, 
            new Employee() {EmployeeId = 2, EMployeeName="manikanta", Gender="female" },
           new Employee() {EmployeeId = 3, EMployeeName="Akshay", Gender="female" }

        };
        //public string this[int empid]
        //{
        //    //get
        //    //{
        //    //    return employeelist.FirstOrDefault(e=> e.EMployeeName).EMployeeName;
        //    //}
        //}
    }
}
