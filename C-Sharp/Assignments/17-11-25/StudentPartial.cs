using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day_17_11_25
{
    public partial class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public partial class Student
    {
        public void DisplayDetails()
        {
            Console.WriteLine($" Student Name : {Name}\n Student Age  : { Age}");
        }
    }
    internal class StudentPartial
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                Name = "Sairam",
                Age = 23
            };
            student.DisplayDetails();
        }
    }
}
