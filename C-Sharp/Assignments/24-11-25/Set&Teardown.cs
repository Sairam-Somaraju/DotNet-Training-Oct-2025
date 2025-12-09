using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _24_11_25
{
    internal class Set_Teardown
    {
        [SetUp]
        public void SetUp()
        {
           WriteLine("SetUpmethod is called Before each Test.");
        }
        [TearDown]
        public void TearDown()
        {
           WriteLine("TearDown method is called AFTER each test.");
        }
        [Test]
        public void TestA()
        {
              WriteLine("Executing Test A");
            Assert.Pass();
        }
        [Test]
        public void TestB()
        {
             WriteLine("Executing  Test B");
            Assert.Pass();
        }

    }
}
