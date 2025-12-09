using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_11_25
{
    internal class Client
    {
        IMath math;
        public Client(IMath math)
        {
            this.math = math;
        }
        public string AddClient(int x, int y)
        {
             
            return math.Add(x, y);
        }
    }
    public class testing
    {
        [Test]
        public void Test1()
        {
            FakeClass f= new FakeClass();
            Client ob= new Client(f);
            var res = ob.AddClient(10, 20);

            Assert.That(res, Is.EqualTo("the sum is 30"));
        }
    }
}
