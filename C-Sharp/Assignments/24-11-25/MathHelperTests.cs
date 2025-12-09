using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_11_25
{
    public class MathHelper
    {
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
    internal class MathHelperTests
    {
        
            [TestCase(2, 3, 6)]
            [TestCase(-1, 5, -5)]
            [TestCase(0, 19, 0)]
            public void MultiplyResult(int a, int b, int res)
            {
                MathHelper math = new MathHelper();

                int result=math.Multiply(a, b);

                Assert.That(result,Is.EqualTo(res));
            }
        
    }
}
