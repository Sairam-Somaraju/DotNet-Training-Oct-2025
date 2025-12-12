using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_12_25_Assessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -------------Connected Architecture---------------------
            EduTrackConnectedArchitecture edu = new EduTrackConnectedArchitecture();
            edu.ShowAllCourses();
            edu.Addstudent();
            edu.SearchByDepartment();
            edu.ShowEnrolledStudentCourses();
            edu.UpdateGrade();
            Console.ReadLine();


            //-----------------------DisConnected Arcitecture-----------------

            EduTrackDisConnectedArchitecture edu2= new EduTrackDisConnectedArchitecture();
            edu2.LoadStudentAndCourses();
            edu2.UpdateCourseCredits();
            edu2.InsertCourseDetails();
            edu2.DeleteStudent();
            Console.ReadLine();
        }
    }
}
