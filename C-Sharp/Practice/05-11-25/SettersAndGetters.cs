using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_11_2025
{
    class student
    {
        private int age;
        private string name;

        private int salary = 50000;
        private string password = "dansuwjd@17624#";

        public int Age
        {
            get
            {
                if (age > 1 && age <=100)
                { 

                Console.WriteLine("age should between 1 to 100 ");
                  }
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Salary
        {
            get { return salary; }
        }
        public string Password
        {
            get { return password; }
        }
    }
    internal class SettersAndGetters
    {
        public static void Main(string[] args)
        {
            student s = new student();
            //s.Age = 20;
            //s.Name = "Sai";
            Console.WriteLine("Enter Student age: ");
            s.Age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name: ");
            s.Name=Console.ReadLine();


            Console.WriteLine("Student Name: "+s.Name);
            Console.WriteLine("Student age: "+s.Age);
            Console.WriteLine("Student Salary: " + s.Salary);
           // Console.WriteLine("Student Password: "+s.Password);
             
        }
    }
}
