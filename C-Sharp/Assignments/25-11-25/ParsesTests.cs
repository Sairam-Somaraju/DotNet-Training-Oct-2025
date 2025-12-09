using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_11_25
{
    public interface IParser
    {
        bool TryParse(string input, out int number);
    }

    public class ParserTests
    {
        [Test]
        public void TryParse_ShouldReturnTrueAndOutput123_WhenInputIs123()
        {
           
            var mockParser = new Mock<IParser>();
            int outValue = 123;

            mockParser.Setup(p => p.TryParse("123", out outValue))
                      .Returns(true);
             
            bool result = mockParser.Object.TryParse("123", out int number);
             
            Assert.That( number, Is.EqualTo(123));
             
            mockParser.Verify(p => p.TryParse("123", out outValue), Times.Once);
        }
    }
}
