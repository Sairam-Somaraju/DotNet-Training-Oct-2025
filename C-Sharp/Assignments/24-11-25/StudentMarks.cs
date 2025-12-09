using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_11_25
{
    internal class StudentMarks
    {
        public static IEnumerable<int> studentMarks()
        {
            yield return 45;
            yield return 50;
            yield return 60;
            yield return 70;
            yield return 55;
        }

        // Test method using TestCaseSource
        [Test, TestCaseSource(nameof(studentMarks))]
        public void TestMarksGreaterThan40(int mark)
        {
            Assert.That(mark, Is.GreaterThan(40), $"Mark {mark} is not greater than 40");
        }
    }
}
