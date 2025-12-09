using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_11_25
{
    internal class MOQDemo
    {
        [Test]
        public void Test3()
        {
            var m = new Mock<IMath>();
            m.Setup(c=>c.Add(10,20)).Returns("the sum is 30");

            Client ob=new Client(m.Object);
            var res = ob.AddClient(10, 20);

            Assert.That(res, Is.EqualTo("the sumis 30"));
        }

        [Test]
        public void Test4()
        {
            var m=new mock<IMath>();
            m.Setup(c => c.Add(It.IsAny<int>(), It.IsAny<int>())).Returns("the sum is 30");

            Client ob=new Client(m.Object);
            var res=ob.AddClient(10, 20);

            Assert.That(res, Is.EqualTo("the sum is 30");
        }
        [Test]
        public void Test6()
        {
            var m = new Mock<IMath>();
            m.Setup(c => c.Add(It.IsAny<int>(), It.IsAny<int>())).Returns("the sum is 30");



            Client ob = new Client(m.Object);
            var res = ob.AddClient(50, 5);// 

            Assert.That(res, Is.EqualTo("the sum is 30"));


            // did u call the add method with parameter or not 
            // did u called the add method atleast once
            // its cross checking if mock is done properly or not
            m.Verify(x => x.Add(50, 5), Times.Once);
        }
    }
}
