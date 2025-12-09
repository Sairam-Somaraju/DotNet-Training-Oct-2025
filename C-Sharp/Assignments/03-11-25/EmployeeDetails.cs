using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_11_25
{
    internal class EmployeeDetails
    {
        private int empId;
        private string empName;
        private string empDesignation;

        public void employeeInfo(int id, string name, string designation)
        {
            empId = id;
            empName = name;
            empDesignation = designation;
        }
        public void displayEmployeeInfo()
        {
            Console.WriteLine("Employee id: " + empId);
            Console.WriteLine("Employee name: " + empName);
            Console.WriteLine("Employee Designation: " + empDesignation);
            Console.WriteLine("**************************");
        }




        //public int addition(int a, int b)
        //{
        //    return (a + b);
        //}
        //public int substraction(int a, int b)
        //{
        //    return (a - b);
        //}

    }
}
