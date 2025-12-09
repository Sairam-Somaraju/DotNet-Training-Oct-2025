using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_11_25_Assessment
{
    internal class EmployeeManagementSystem
    {
        public class Employee
        {
            public int EmpId { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
            public double Salary { get; set; }
            public double Experience { get; set; }
        }
        static void Main(string[] args)
        {
            List<Employee> employeesList = new List<Employee>()
            {
                new Employee() {EmpId = 101, Name = "Sairam", Department = "IT", Salary = 300000,  Experience = 2},
                new Employee() {EmpId = 102,Name = "Venkat",Department = "Testing",Salary = 500000,Experience = 1.5},
                new Employee() { EmpId = 103, Name = "Adisiva", Department = "HR", Salary = 350000, Experience = 2.6 },
                new Employee() { EmpId = 104, Name = "prudhvi", Department = "Developer", Salary = 40000, Experience = 1 },
                new Employee() { EmpId = 105, Name = "Sumanth", Department = "Sales", Salary = 30000, Experience = 3 },
                new Employee() { EmpId = 106, Name = "Vinay", Department = "finance", Salary = 600000, Experience = 3.6 },
                new Employee() { EmpId = 107, Name = "Gopi", Department = "Mareting", Salary = 200000, Experience = 4 },
                new Employee() { EmpId = 108, Name = "Teja", Department = "IT", Salary = 80000, Experience = 4.4},
                new Employee() { EmpId = 109, Name = "Rajesh", Department = "HR", Salary = 60000, Experience = 5.5 },
                new Employee() { EmpId = 110, Name = "Satheesh", Department = "Sales", Salary = 300000, Experience = 1.5 },

            };

            Console.WriteLine("----All Employees List----");
            foreach (var emp in employeesList)
            {
                Console.WriteLine($"{emp.EmpId} - {emp.Name} - {emp.Department} - {emp.Salary} - {emp.Experience} yrs");
            }

            Console.WriteLine("---Filtered by Salary---");
            Console.WriteLine("Entered the Salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            var highSalary = employeesList.FindAll(e => e.Salary > salary);
            Console.WriteLine("Employees earning more than " + salary + ":");
            foreach (var emp in highSalary)
            {
                Console.WriteLine($"{emp.EmpId} - {emp.Name} - {emp.Department} - {emp.Salary} - {emp.Experience} yrs");
            }


            Console.WriteLine("---Filtered by Department---");
            Console.WriteLine("Enter the Department name: ");
            string dName = Console.ReadLine();
            var itEmployees = employeesList.FindAll(e => e.Department == dName);
             Console.WriteLine("\n Employees in " + itEmployees + " Department:");
            foreach (var emp in itEmployees)
            {
                Console.WriteLine($"{emp.EmpId} - {emp.Name} - {emp.Department} - {emp.Salary} - {emp.Experience} yrs");
            }


            Console.WriteLine("---Filtered by Experience---");
            Console.WriteLine("Enter the Experience: ");
            double experience = Convert.ToDouble(Console.ReadLine());
            var experienced = employeesList.FindAll(e => e.Experience > experience);
            Console.WriteLine("\nEmployees with more than " + experience + " years experience:");
            foreach (var emp in experienced)
            {
                Console.WriteLine($"{emp.EmpId} - {emp.Name} - {emp.Department} - {emp.Salary} - {emp.Experience} yrs");

            }


            Console.WriteLine("---Filtered by Name---");
            Console.WriteLine("Enter the Character to filter the names: ");
            char ch = Convert.ToChar(Console.ReadLine());
            var nameSearch = employeesList.FindAll(e => e.Name.Contains(ch));

            Console.WriteLine("\nEmployees whose name contains " + ch + " : ");
            foreach (var emp in nameSearch)
            {
                Console.WriteLine($"{emp.EmpId} - {emp.Name} - {emp.Department} - {emp.Salary} - {emp.Experience} yrs");
            }


            Console.WriteLine("---Sort by Names A to Z--- ");
            var sortByName = new List<Employee>(employeesList);
            sortByName.Sort((a, b) => a.Name.CompareTo(b.Name));
            foreach( var emp in sortByName)
            {
                Console.WriteLine($"{emp.EmpId} - {emp.Name} - {emp.Department} - {emp.Salary} - {emp.Experience} yrs");

            }


            Console.WriteLine("---Sort by High to Low--- ");
            var sortBySalary = new List<Employee>(employeesList);
            sortBySalary.Sort((a, b) => b.Salary.CompareTo(a.Salary));
            foreach( var emp in sortBySalary)
            {
                Console.WriteLine($"{emp.EmpId} - {emp.Name} - {emp.Department} - {emp.Salary} - {emp.Experience} yrs");

            }

            
            Console.WriteLine("---Sort by Experience---");
            var sortByExperience = new List<Employee>(employeesList);
            sortByExperience.Sort((a, b) => a.Experience.CompareTo(b.Experience));
            foreach(var emp in sortByExperience)
            {
                Console.WriteLine($"{emp.EmpId} - {emp.Name} - {emp.Department} - {emp.Salary} - {emp.Experience} yrs");

            }


            Console.WriteLine("---Promotion List---");
            Console.WriteLine("Enter the how many years to get promotion: ");
            double years=Convert.ToDouble(Console.ReadLine());
            var promotionList = employeesList.FindAll(e => e.Experience >= years);
            foreach (var emp in promotionList)
            {
                Console.WriteLine($"{emp.EmpId} - {emp.Name} - {emp.Department} - {emp.Salary} - {emp.Experience} yrs");

            }

        }
    }
}
