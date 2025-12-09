using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _24_11_25.Tests;

namespace _24_11_25
{
    internal class Lifecycle
    {
        [SetUp]// calls before running each test method
        public void T1()
        {
            //logic (are u admin or not)


            var res = File.AppendText("d:\\app.txt");
            res.WriteLine("Setup Method is called");
            res.Dispose();

        }

        [TearDown]// calls after running each test method
        public void T2()
        {// do logging activity

            var res = File.AppendText("d:\\app.txt");
            res.WriteLine("Teardown Method is called");
            res.Dispose();

        }

        [OneTimeSetUp]// calls before running test
        public void T3()
        {
            //database connection logic goes here
            var res = File.AppendText("d:\\app.txt");
            res.WriteLine("OnTimeSetup Method is called");
            res.Dispose();

        }

        [OneTimeTearDown]// calls after all the test is executed
        public void T4()
        {
            // close the database connection

            var res = File.AppendText("d:\\app.txt");
            res.WriteLine("Onetimeteardown Method is called");
            res.Dispose();

        }

        [Test]
        public void Add()
        {
            var res = File.AppendText("d:\\app.txt");
            res.WriteLine("Add Method is called");
            res.Dispose();
            Assert.Pass();
        }
        [Test]
        public void Divide()
        {
            var res = File.AppendText("d:\\app.txt");
            res.WriteLine("divide Method is called");
            res.Dispose();
            Assert.Pass();
        }




        [Test]
        //  [Ignore("not yet ready ...")]
        [Category("simplemath")]
        public void Test2()
        {
            // this method is created to test Multiply method


            MyMath ob = new MyMath();
            int a = 5;
            int b = 10;

            int result = ob.Multiply(a, b);

            Assert.That(result, Is.EqualTo(50));
        }
        [Test]
        [Category("db")]
        public void Test3()
        {
            MyMath ob = new MyMath();
            var res = ob.Database(10, 20);
            Assert.That(res, Is.EqualTo(20));
        }
    }


}
