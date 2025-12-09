using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_11_25
{
    internal class MOQFake
    {
        [Test]  // fake verion of MOQ
        public void Test5()
        {
            // how to use mock framework
            // readymade way to work with sub and fake

            var m = new Mock<FakeDemo>();
            m.Setup(c => c.GetData(It.IsAny<string>())).Returns((string d) => {
                List<string> st = new List<string>()
            {
                "India","canada","uk","us"
            };
                return st.Where(c => c.Contains(d)).ToList();

            });


            // "the sum is 30");2(It.IsAny<int>(), It.IsAny<int>())).Returns((int a, int b) => a + b);//fake


            Client1 ob = new Client1(m.Object);
            var res = ob.AddClient("u");// 

            Assert.That(res.Count, Is.GreaterThan(0));

        }

    }
}
