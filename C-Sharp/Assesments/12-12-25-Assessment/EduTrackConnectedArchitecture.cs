using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _12_12_25_Assessment
{
    internal class EduTrackConnectedArchitecture
    {
        SqlConnection con =new SqlConnection(@"Integrated security=true;Database=EduTrack;server=(localdb)\MSSQLLocalDB");

        //Task-2.1
         public void ShowAllCourses()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select CourseId, CourseName, Credits, Semester from Courses", con);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    Console.WriteLine($"{rd["CourseId"]}  {rd["CourseName"]}  {rd["Credits"]}  {rd["Semester"]}");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("SQL Error: "+ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        //Task-2
        public void Addstudent()
        {
            try
            {
                con.Open();

                Console.Write("Enter Full Name: ");
                string fullName = Console.ReadLine();
                Console.Write("Enter Email: ");
                string email = Console.ReadLine();
                Console.Write("Enter Department: ");
                string department = Console.ReadLine();
                Console.Write("Enter Year Of Study: ");
                int yearOfStudy = Convert.ToInt32(Console.ReadLine());

                SqlCommand cmd = new SqlCommand(@"insert into Students (FullName, Email, Department, YearOfStudy) VALUES (@FullName, @Email, @Department, @YearOfStudy)", con);
                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Department", department);
                cmd.Parameters.AddWithValue("@YearOfStudy", yearOfStudy);

                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine($" {rows}New Student Added Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("SQL Error: "+ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        //Task-3
        public void SearchByDepartment()
        {
            try
            {
                con.Open();
                Console.Write("Enter Department to Search: ");
                string department = Console.ReadLine();
                SqlCommand cmd = new SqlCommand("Select StudentId, FullName, Email, YearOfStudy FROM Students Where Department = @Dept", con);
                cmd.Parameters.AddWithValue("@Dept", department);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    Console.WriteLine($"{rd["StudentId"]}   {rd["FullName"]}   {rd["Email"]}   {rd["YearOfStudy"]}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        //Task-4

        public void ShowEnrolledStudentCourses()
        {
            try
            {
                con.Open();
                Console.Write("Enter Student ID: ");
                int studentId = Convert.ToInt32(Console.ReadLine());
                SqlCommand cmd = new SqlCommand(@"Select C.CourseName, C.Credits, E.EnrollDate, E.Grade From Enrollments E
                JOIN Courses C ON E.CourseId = C.CourseId WHERE E.StudentId = @StudentId", con);
                cmd.Parameters.AddWithValue("@StudentId", studentId);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    Console.WriteLine($"{rd["CourseName"]}   {rd["Credits"]}   {rd["EnrollDate"]}   {rd["Grade"]}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        //Task-5
        public void UpdateGrade()
        {
            try
            {
                con.Open();
                Console.Write("Enter Enrollment ID: ");
                int enrollmentId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Grade: ");
                string grade = Console.ReadLine();

                SqlCommand cmd = new SqlCommand("Update Enrollments SET Grade = @Grade Where EnrollmentId = @Id", con);
                cmd.Parameters.AddWithValue("@Grade", grade);
                cmd.Parameters.AddWithValue("@Id", enrollmentId);

                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine($"{rows} enrollment updated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("SQL Error: "+ex.Message);
            }
            finally 
            { 
                con.Close();
            }
        }
    }
}
