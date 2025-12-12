using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_12_25_Assessment
{
    internal class EduTrackDisConnectedArchitecture
    {
        SqlConnection con = new SqlConnection(@"Integrated security=true;Database=EduTrack;server=(localdb)\MSSQLLocalDB");

        //Task -1
        public void LoadStudentAndCourses()
        {
            try
            {
                SqlDataAdapter ad = null;

                con.Open();
                ad = new SqlDataAdapter("Select * From Students", con);
                DataSet ds = new DataSet();
                ad.Fill(ds, "Students");

                ad = new SqlDataAdapter("Select * From Courses", con);
                ad.Fill(ds, "Courses");
                Console.WriteLine("-----Student Details-----");
                DataTable students = ds.Tables["Students"];

                for (int i = 0; i < students.Rows.Count; i++)
                {
                    Console.WriteLine($"{students.Rows[i]["StudentId"]}  {students.Rows[i]["FullName"]}  {students.Rows[i]["Email"]}  {students.Rows[i]["Department"]}   {students.Rows[i]["YearOfStudy"]}");
                }

                Console.WriteLine("\n------Corses Details--------");
                DataTable courses = ds.Tables["Courses"];
                for (int i = 0; i < courses.Rows.Count; i++)
                {
                    Console.WriteLine($"{courses.Rows[i]["CourseId"]}     {courses.Rows[i]["CourseName"]}    {courses.Rows[i]["Credits"]}    {courses.Rows[i]["Semester"]}");
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

        //Task-2
        public void UpdateCourseCredits()
        {
            SqlDataAdapter ad = null;
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                ad=new SqlDataAdapter("Select * From Courses", con);
                SqlCommandBuilder builder = new SqlCommandBuilder(ad);
                ad.Fill(ds, "Courses");

                Console.Write("Enter CourseId to update credits: ");
                int courseId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter New Credits: ");
                int newCredits = Convert.ToInt32(Console.ReadLine());

                DataTable table = ds.Tables["Courses"];
                DataRow[] rows = table.Select($"CourseId = {courseId}");

                if (rows.Length > 0)
                {
                    rows[0]["Credits"] = newCredits;
                    ad.Update(ds, "Courses");
                    Console.WriteLine("Credits updated successfully");
                }
                else
                {
                    Console.WriteLine("Course not found");
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine("SQL Error: "+ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        //Task-3
        public void InsertCourseDetails()
        {
            SqlDataAdapter ad = null;
            DataSet ds = new DataSet();

            try
            {
                con.Open();
                ad = new SqlDataAdapter("Select * From Courses", con);
                SqlCommandBuilder builder = new SqlCommandBuilder(ad);
                ad.Fill(ds, "Courses");

                Console.Write("Enter Course Name: ");
                string courseName = Console.ReadLine();

                Console.Write("Enter Credits: ");
                int credits = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Semester (Fall/Spring): ");
                string semester = Console.ReadLine();

                ds.Tables["Courses"].Rows.Add(null, courseName, credits, semester);
                ad.Update(ds, "Courses");
                Console.WriteLine("Course inserted successfully!");
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
        //Task-4
        public void DeleteStudent()
        {
            SqlDataAdapter ad = null;
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                ad = new SqlDataAdapter("Select * From Students", con);
                SqlCommandBuilder builder = new SqlCommandBuilder(ad);
                ad.Fill(ds, "Students");
                Console.Write("Enter StudentId to Delete: ");
                int studentId = Convert.ToInt32(Console.ReadLine());
                DataTable table = ds.Tables["Students"];
                DataRow[] rows = table.Select($"StudentId = {studentId}");
                if (rows.Length > 0)
                {
                    rows[0].Delete();
                    ad.Update(ds, "Students");
                    Console.WriteLine("Student deleted successfully");
                }
                else
                {
                    Console.WriteLine("Student id not found");
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

    }
}
