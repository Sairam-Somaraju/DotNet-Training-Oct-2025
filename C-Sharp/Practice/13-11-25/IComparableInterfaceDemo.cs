using _13_11_25;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_11_25
{
    class InfiniteEmployee:IComparable<InfiniteEmployee>
    {
        public int Empid {  get; set; }
        public string Name { get; set; }
        public int Salary {  get; set; }
        public int Age { get; set; }
        public string Location { get; set; }

        public int CompareTo(InfiniteEmployee other)
        {
            return Salary.CompareTo(other.Salary);
        }
    }
    internal class IComparableInterfaceDemo
    {
        public static void Main(String[] args)
        {
            List<InfiniteEmployee> infiniteEmployees = new List<InfiniteEmployee>();
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 1807018, Name = "Kanishka Chandran", Salary = 37500, Age = 20, Location = "Hyderabad" });
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 1807023, Name = "Deepalakshmi", Salary = 60000, Age = 21, Location = "Hyderabad" });
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 1807031, Name = "Aasritha", Salary = 80000, Age = 21, Location = "Chennai" });
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 1807005, Name = "Sairam", Salary = 18000, Age = 23, Location = "Chennai" });
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 1807013, Name = "Akshay", Salary = 29000, Age = 23, Location = "Chennai" });

            Console.WriteLine("Employee Details are ");
            foreach (var emp in infiniteEmployees)
            {
                Console.WriteLine($" Empid: {emp.Empid},Name: {emp.Name}, Salary: {emp.Salary}, Age: {emp.Age}, Location: {emp.Location}");
            }
            infiniteEmployees.Sort();
            Console.WriteLine("Employee Details After Sort");
            foreach (var emp in infiniteEmployees)
            {
                Console.WriteLine($" Empid: {emp.Empid},Name: {emp.Name}, Salary: {emp.Salary}, Age: {emp.Age}, Location: {emp.Location}");
            }
            Console.WriteLine();
        }
     }
}


