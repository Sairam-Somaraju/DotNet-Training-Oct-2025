using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_11_25
{
    public interface ILogger
    {
        void Log(string message);
    }

    // Class under test
    public class Processor
    {
        private readonly ILogger _logger;

        public Processor(ILogger logger)
        {
            _logger = logger;
        }

        public void Process()
        {
            _logger.Log("Start");
            _logger.Log("Processing");
            _logger.Log("End");
        }
    }

    // Test class
    public class ILoggetTests
    {
        [Test]
        public void Process_ShouldCallLogThreeTimes()
        {
            // Arrange
            var mockLogger = new Mock<ILogger>();
            var processor = new Processor(mockLogger.Object);

            // Act
            processor.Process();

            // Assert - verify Log() was called 3 times
            mockLogger.Verify(l => l.Log(It.IsAny<string>()), Times.Exactly(3));

            // Optionally verify the exact messages in order
            mockLogger.Verify(l => l.Log("Start"), Times.Once);
            mockLogger.Verify(l => l.Log("Processing"), Times.Once);
            mockLogger.Verify(l => l.Log("End"), Times.Once);
        }
    }
}
