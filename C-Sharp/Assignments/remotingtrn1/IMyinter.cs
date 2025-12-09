using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remotingtrn2
{
    
    public interface IMyinter
    {
        void ShowAllStudents();
        Student GetStudent(int id);
    }
    [Serializable]
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public int TotalMarks { get; set; }
         
        public override string ToString() =>
            $"{Name}, Class: {Class}, Total Marks: {TotalMarks}";
    }
}
