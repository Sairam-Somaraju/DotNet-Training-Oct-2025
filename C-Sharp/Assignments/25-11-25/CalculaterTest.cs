using Moq;
using NUnit.Framework;


namespace _25_11_25
{
     
        public interface ICalculator
        {
            int Add(int a, int b);
        }

        public class CalculatorTests
        {
            [Test]
            public void Add_ShouldReturn5_AndBeCalledOnce()
            {
                // Arrange
                var mockCalc = new Mock<ICalculator>();

                mockCalc.Setup(c => c.Add(2, 3))
                        .Returns(5);

                // Act
                int result = mockCalc.Object.Add(2, 3);

                // Assert
                Assert.That(result,Is.EqualTo(result));

                // Verify that Add(2,3) was called exactly once
                mockCalc.Verify(c => c.Add(2, 3), Times.Once);
            }
        }
    }
