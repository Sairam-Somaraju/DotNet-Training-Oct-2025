using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03_11_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[10];
            //Console.WriteLine("Enter the " + arr.Length + " numbers");
            //for(int i=0;i<arr.Length;i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //foreach(int nums in arr)
            //{
            //    Console.Write(nums+" ");
            //}
            //Console.ReadLine();




            //int[] arr2 = new int[10];
            //Console.WriteLine("Enter the " + arr2.Length + " numbers");
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    arr2[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int temp = arr2[0];
            //for(int i=0;i<arr2.Length;i++)
            //{
            //    if (arr2[i]>=temp)
            //    {
            //        temp = arr2[i];
            //    }
            //}
            //Console.WriteLine("The largest number is: "+temp);

            //Console.ReadLine();




            //int[] arr3 = new int[10];
            //Console.WriteLine("Enter the " + arr3.Length + " numbers");
            //for (int i = 0; i < arr3.Length; i++)
            //{
            //    arr3[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for(int i=0;i<arr3.Length;i++)
            //{

            //    int count = Convert.ToInt32(Console.ReadLine());
            //    count = 0;
            //     for(int j=0;j<arr3.Length;j++)
            //    {
            //        if (arr3[i] == arr3[j] && i!=j)
            //        {
            //            count++;
            //        }
            //    }
            //    Console.WriteLine(arr3[i] + " Occurance is " + count);
            //}
            //Console.ReadLine();



            //int rowsize, colsize;
            //Console.WriteLine("Enter the number of rows ");
            //rowsize = Convert.ToInt32(Console.ReadLine());
            //colsize = 5;
            //int[,] StudentMarks = new int[rowsize, colsize];
            //for(int i=0; i<rowsize;i++)
            //{
            //    Console.WriteLine($"ENter the marks for student{i + 1}");
            //    for(int j=0;j<colsize;j++)
            //    {
            //        Console.WriteLine($"Enter the marks for subject {j + 1}");
            //        StudentMarks[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("Displaying the marks of students ");
            //for(int i=0;i<rowsize;i++)
            //{
            //   Console.WriteLine("\nstudent "+(i+1)+" marks are\n");
            //    int  sum = 0;
            //    for(int j=0;j<colsize;j++)
            //    {

            //        Console.Write(StudentMarks[i, j] + "\t");
            //        sum += StudentMarks[i, j];

            //    }
            //    Console.WriteLine("\n");
            //    Console.WriteLine("Total marks is: " + sum);
            //}
            //Console.ReadLine();



            //Console.WriteLine("Reversed Array");
            //int[] arr = new int[5]{ 1, 2, 3, 4, 5 };
            //for (int i =0; i<arr.Length/2; i++)
            //{
            //    int temp = arr[i];
            //    arr[i] = arr[arr.Length - i - 1];
            //    arr[arr.Length - i - 1]= temp;
            //}
            //Console.WriteLine("After reversed my array using logic..");
            //foreach(int nums in arr)
            //{
            //    Console.Write(nums + " ");
            //}
            //Console.WriteLine("\n");

            //Console.WriteLine("After reversing my array using rev() method..");
            //arr.Reverse();

            //foreach(int rev in arr)
            //{
            //    Console.Write(rev + " ");
            //}
            //Console.ReadLine();



            //    Console.WriteLine("Jagged Array");
            //int[][] jaggedArray = new int[4][];
            //jaggedArray[0] = new int[3] { 3, 1, 4 };
            //jaggedArray[1] = new int[2] { 3, 4 };
            //jaggedArray[2] = new int[5] { 7, 1, 2,6,0 };
            //jaggedArray[3] = new int[6] { 5,8,2,3, 1, 4 };

            //for(int i=0;i<jaggedArray.Length;i++)
            //{
            //    Console.WriteLine("Element({0}): ", i + 1);
            //    for(int j = 0; j < jaggedArray[i].Length;j++)
            //    {
            //        Console.Write(jaggedArray[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();




            //string[][] names = new string[4][] {
            //  new string[] { "Dhoni", "Raina", "Kohli" },
            //  new string[] { "Red", "Black", "Green","White" },
            //  new string[] { "Bahubali-1", "Bahubali-2" },
            //  new string[] { "Java", "Python", "C","C++","C#" }, };

            //for(int i=0;i<names.Length;i++)
            //{
            //    Console.WriteLine("Name List[{0}]: ", i + 1);
            //    for(int j = 0; j < names[i].Length;j++)
            //    {
            //        Console.Write(names[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();



            //Calculator cl = new Calculator();
            //int num1, num2;
            //Console.WriteLine("Enter the number1 ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the number2 ");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //cl.addition(num1, num2);

            //cl.substraction(num1, num2);
            //Console.ReadLine();




            //EmployeeDetails emp1 = new EmployeeDetails();
            //emp1.employeeInfo(1807005, "Sairam", "Associate Software Engineer");
            //emp1.displayEmployeeInfo();
            //EmployeeDetails emp2 = new EmployeeDetails();
            //emp2.employeeInfo(1807006, "Manikanta", "Associate Software Engineer");
            //emp2.displayEmployeeInfo();
            //EmployeeDetails emp3 = new EmployeeDetails();
            //emp3.employeeInfo(1807012, "Akshay", "Associate Software Engineer");
            //emp3.displayEmployeeInfo();
            //Console.ReadLine();





            //int id;
            //string empname;
            //string empdes;
            //Console.WriteLine("Enter the Empoyee id: ");
            //id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the Empoyee name: ");
            //empname = Console.ReadLine();
            //Console.WriteLine("Enter the Empoyee Designation: ");
            //empdes = Console.ReadLine();
            //EmployeeDetails emp1 = new EmployeeDetails();
            //emp1.employeeInfo(id,empname,empdes);
            //emp1.displayEmployeeInfo();
            //EmployeeDetails emp2 = new EmployeeDetails();
            //emp2.employeeInfo(id, empname, empdes);
            //emp2.displayEmployeeInfo();
            //Console.ReadLine();




            //Console.WriteLine("Enter the Number 1: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the Number 2: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //EmployeeDetails emp = new EmployeeDetails();
            //Console.WriteLine("Addition is: " + emp.addition(num1, num2));
            //Console.WriteLine("Substraction is: "+emp.substraction(num1, num2));
            ////Console.ReadLine();
            ///




            //Calculator cl = new Calculator();
            //cl.calculator(50, 30, out int addResult, out int substraction, out int multiplication, out int division);
            //Console.WriteLine($" Sum= {addResult}\n Difference= {substraction}\n Multiplication= {multiplication}\n Division= {division}");

            //Console.WriteLine("*******Student Marks Evolution System******");
            //Console.WriteLine("Enter the no of Students ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("----Enter Details for Student 1---- ");
            //Console.WriteLine("Enter the Student name: ");
            //String name = Console.ReadLine();
            //Console.WriteLine("Enter subject1 marks : ");
            //int sub1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter subject2 marks : ");
            //int sub2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter subject3 marks : ");
            //int sub3 = Convert.ToInt32(Console.ReadLine());

            //StudentInfo std= new StudentInfo();
            //std.studentInfo(name, sub1, sub2, sub3);


            Console.Write("Enter the number of students: ");
            int numStudents = Convert.ToInt32(Console.ReadLine());

            StudentInfo[] students = new StudentInfo[numStudents]; 
 
            for (int i = 0; i <numStudents; i++)
            {
                students[i] = new StudentInfo();

                Console.WriteLine($"\nEnter details for Student {i + 1}:");
                
                Console.Write("Enter Student Name: ");
                students[i].Name = Console.ReadLine();

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Enter marks for Subject {j + 1}: ");
                    students[i].SubjectMarks[j] = Convert.ToInt32(Console.ReadLine());
                }
            }
             
            Console.WriteLine("\n***********STUDENT REPORTS**********");
            for (int i = 0; i < numStudents; i++)
            {
                students[i].DisplayResult();
            }
  
        }
    }
}
