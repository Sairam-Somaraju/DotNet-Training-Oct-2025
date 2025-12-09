using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;



namespace _05_11_2025
{
     
    class persons
    {
         
        protected string name;
        protected int age;
        protected string location;

          public persons(string name, int age, string location)
        {
            this.name = name;
            this.age = age;
            this.location = location;
            Console.WriteLine("Persons Base Class  ");
        }

         public void GetPersonDetails()
        {
            Console.WriteLine("\n====== Enter Person Details ======");
            Console.Write("Enter the name of the Person: ");
            name = Console.ReadLine();

            Console.Write("Enter the location of the Person: ");
            location = Console.ReadLine();

            Console.Write("Enter the age of the Person: ");
            age = Convert.ToInt32(Console.ReadLine());
        }

         public void DisplayPersonDetails()
        {
            Console.WriteLine("\n====== Person Details ======");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Location: {location}");
            Console.WriteLine($"Age: {age}");
        }
    }

     class employees : persons
    {
         int empId;
        string empDesignation;
        int empSalary;

       

        public employees(string name, int age, string location, int empId, string empDesignation, int empSalary)
            : base(name, age, location)
        {
            this.empId = empId;
            this.empDesignation = empDesignation;
            this.empSalary = empSalary;
            Console.WriteLine("Employees Child Class ");
        }

         public void GetEmployeeDetails()
        {
             GetPersonDetails();

             Console.WriteLine("\n====== Enter Employee Details ======");
            Console.Write("Enter Employee ID: ");
            empId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Designation: ");
            empDesignation = Console.ReadLine();

            Console.Write("Enter Employee Salary: ");
            empSalary = Convert.ToInt32(Console.ReadLine());
        }

         public void DisplayEmployeeDetails()
        {
             DisplayPersonDetails();

             Console.WriteLine("\n====== Employee Details ======");
            Console.WriteLine($"Employee ID: {empId}");
            Console.WriteLine($"Designation: {empDesignation}");
            Console.WriteLine($"Salary: {empSalary}");
        }
    }

     internal class InheritanceWithConstructor
    {
        static void Main(string[] args)
        {
 
             employees emp = new employees("sai",24,"chennai",101,"trainee",30000);

             emp.GetEmployeeDetails();

             emp.DisplayEmployeeDetails();

         }
    }
}
