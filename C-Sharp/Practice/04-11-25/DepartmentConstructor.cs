using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_11_25
{
    internal class DepartmentConstructor
    {
        int depid;
        string name, location;

        static DepartmentConstructor()
        {
            Console.WriteLine("Static Constructor..");
        }
        
        public DepartmentConstructor()
        {
            Console.WriteLine("Default Constructor...");
            depid = 1807005;
            name = "software";
            location = "chennai";
        }
        public DepartmentConstructor(int depid, string name, string location)
        {
            Console.WriteLine("Parameterized Constructor...");
            this.depid = depid;
            this.name = name;
            this.location = location;
        }

        public DepartmentConstructor(DepartmentConstructor dept)
        {
            Console.WriteLine("Copy Constructor");
            this.depid = dept.depid;
            this.name = dept.name;
            this.location = dept.location;
        }
        public  void getDepartmentInfo()
        {
            Console.WriteLine("Enter the Department id: ");
             depid=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Department name: ");
             name=Console.ReadLine();
            Console.WriteLine("Enter the Department location: ");
            location = Console.ReadLine();
 
        }


        public  void DisplayDepartmentInfo()
        {
            Console.WriteLine($" Department ID: {depid}\n Department  name: {name} \n Department Location: {location}");
        }
    }
}
