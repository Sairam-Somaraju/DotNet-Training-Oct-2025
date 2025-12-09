using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_11_2025
{
    public class Person
    {
        public Person()
        {
            Console.WriteLine("Person Constructor called");
        }
        public string Name;
        public void ShowName() => Console.WriteLine($"Name : {Name}");
    }

    class Teacher : Person
    {
        public Teacher()
        {
            Console.WriteLine("Teacher Constructor called");
        }
        public string course;
        public void ShowCourse() => Console.WriteLine($"{Name} teaches {course}");
    }

    class Professor : Teacher
    {
        public Professor()
        {
            Console.WriteLine("Professor Constructor called");
        }
        public void ConductResearch() => Console.WriteLine($"{Name} conducting R&D in{course}");
    }

    internal class MultilevelInheritance
    {
        public static void Main(string[] args)
        {
            Professor pf= new Professor();
            Professor pf1 = new Professor() { Name = "peter", course = "Maths" };
            pf.course = "C#";
            pf.Name = "Geetha";
            pf.ShowName();
            pf.ShowCourse();
            pf.ConductResearch();
        }
    }
}
