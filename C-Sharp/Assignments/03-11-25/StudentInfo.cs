using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_11_25
{
    internal class StudentInfo
    {


        public string Name; 
        public int[] SubjectMarks = new int[3];

        public void CalculateResult(out int total, out double average, out char grade)
        {
            total = 0;
            for (int i = 0; i < SubjectMarks.Length; i++)
            {
                total =total+ SubjectMarks[i]; 
            }

            average = total / 3.0;

            if (average >= 90)
            {
                grade = 'A';
            }
            else if (average >= 75)
            {
                grade = 'B';
            }
            else if (average >= 60)
            {
                grade = 'C';
            }
            else if (average >= 40)
            {
                grade = 'D';
            }
            else
                grade = 'F';
        }

        public void DisplayResult()
        {
            CalculateResult(out int total, out double average, out char grade);

            Console.WriteLine("\n------------------------------");
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Subject Marks: {0}, {1}, {2}",
            SubjectMarks[0], SubjectMarks[1], SubjectMarks[2]);
            Console.WriteLine("Total Marks: " + total);
            Console.WriteLine("Average Marks: " + average);
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("------------------------------\n");
        }
    }
}
