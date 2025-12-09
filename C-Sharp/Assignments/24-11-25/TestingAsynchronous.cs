using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_11_25
{
    public class StudentServices
    {
        public async Task<int> GetMarksAsync()
        {
            await Task.Delay(100);
            return 90;
        }
    }
    internal class TestingAsynchronous
    {
        [Test]
        public async Task GetMarksAsync()
        {
            StudentServices service = new StudentServices();
             
            int result = await service.GetMarksAsync();
 
            Assert.That(result, Is.EqualTo(90));
        }
    }
}
