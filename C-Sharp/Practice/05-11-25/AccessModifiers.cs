using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_11_2025
{

    class Person
    {
        string name;
        int age;
        string location;

        public void GetPersonDetails()
        {
            
            Console.WriteLine("Enter the name of the Person : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the Location Person: ");
            location= Console.ReadLine();
            Console.WriteLine("Enter the age of Person: ");
            age = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayPersonDetails()
        {
            Console.WriteLine("***********Display Person Details**************");
            Console.WriteLine($" Person Name: {name}\n Person Location: {location}\n Person Age: {age}");
        }
    }

    class Employee:Person
    {
        int empId;
        string empDesignation;
        int empSalary;

        public void GetEmployeeDetails()
        {
            GetPersonDetails();
            Console.WriteLine("Enter Employee ID: ");
            empId=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Designation: ");
            empDesignation=Console.ReadLine();
            Console.WriteLine("Enter Employee Salary: ");
            empSalary=Convert.ToInt32(Console.ReadLine());

            DisplayEmployeeDetails();

        }
        void DisplayEmployeeDetails()
        {
            Console.WriteLine("***********Employee details************");
            Console.WriteLine($" Employee ID: {empId}\n   Employee Designation: {empDesignation}\n Employee Salary: {empSalary}");
        }
    }
    internal class AccessModifiers
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.GetEmployeeDetails();
            emp.DisplayPersonDetails();
         }
    }
}
