using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_11_25
{
    public class StudentService
    {
        public void ValidateAge(int age)
        {
            if(age<0)
            {
                throw new ArgumentException("Invalid Age");
            }
        }
    }
    internal class StudentServiceTests
    {
        [Test]
        public void ValidateStudentAge()
        {
            StudentService studentService = new StudentService();

            Assert.Throws<ArgumentException>(() => studentService.ValidateAge(-5));
        }
    }
}
