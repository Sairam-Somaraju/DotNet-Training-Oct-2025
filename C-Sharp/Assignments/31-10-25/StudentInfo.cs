using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_10_2025
{
    internal class StudentInfo
    {
        public static void Main(String[] args)
        {
            String stuName;
            Console.WriteLine("ENter the Student name :");
            stuName = Console.ReadLine();
            int marks;
            Console.WriteLine("Enter the Student matrks :");
            marks = Convert.ToInt16(Console.ReadLine());
            if (marks >= 90)
            {
                Console.WriteLine("A+");
            }
            else if (marks >= 80 && marks <= 89)
            {
                Console.WriteLine("A");
            }
            else if (marks >= 70 && marks <= 79)
            {
                Console.WriteLine("B");
            }
            else if (marks >= 60 && marks <= 69)
            {
                Console.WriteLine("C");
            }
            else if (marks >= 50 && marks <= 59)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
