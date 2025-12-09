using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace _25_11_25
{
    public class Client1
    {
        FakeDemo demo;

        public Client1(FakeDemo demo)
        {
            this.demo = demo;
        }

        public List<string> AddClient(string st)
        {
            return demo.GetData(st);
        }
    }
    public class Testing2
    {
        [Test]
        public void Test2()
        {
            Fakecls f = new Fakecls();
            Client1 c = new Client1(f);
            var res = c.AddClient("u");

            Assert.That(res.Count, Is.GreaterThan(0));
        }
    }
}
