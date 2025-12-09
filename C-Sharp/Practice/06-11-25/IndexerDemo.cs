using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_11_2025
{
    class StudentMarks
    {
        private int[] marks = new int[5];
        public int this[int index]
        {
            get
            {
                if(index<0 || index>=marks.Length)
                {
                    Console.WriteLine("Invalid Index! Returning-1");
                    return -1;
                }
                return marks[index];
            }
            set
            {
                if(index<0 || index>=marks.Length)
                {
                    Console.WriteLine("IOnvalid Index! cannot set value");
                }
                else
                {
                    marks[index] = value;
                }
            }
        }
        public void DisplayMarks()
        {
            Console.WriteLine("Marks of Students");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine($"student {i + 1}: {marks[i]}");
            }
        }
    }
    internal class IndexerDemo
    {
        public static void Main(string[] args)
        {
            StudentMarks studentMarks = new StudentMarks();

            //setting a marks using indexer
            studentMarks[0] = 85;
            studentMarks[1] = 55;
             studentMarks[2] = 67;
            studentMarks[3] = 92;
            studentMarks[4] = 76;

            //getting marks using indexer
            for(int i = 0;i<5;i++)
            {
                Console.WriteLine($"Marks of Student {i+1}: {studentMarks[i]}");
            }
            studentMarks.DisplayMarks();
        }

    }
}
