using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_11_25
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    // Interface to mock
    public interface ICustomerRepository
    {
        Customer GetCustomerById(int id);
    }

    // Service under test
    public class CustomerService
    {
        private readonly ICustomerRepository _repo;

        public CustomerService(ICustomerRepository repo)
        {
            _repo = repo;
        }

        public string GetCustomerName(int id)
        {
            var customer = _repo.GetCustomerById(id);
            return customer?.Name ?? "Unknown";
        }
    }

    // Test class
    public class CustomerTests
    {
        [Test]
        public void GetCustomerName_ShouldReturnJohn_WhenIdIs1()
        {
            // Arrange
            var mockRepo = new Mock<ICustomerRepository>();

            mockRepo.Setup(r => r.GetCustomerById(1))
                    .Returns(new Customer { Id = 1, Name = "John" });

            var service = new CustomerService(mockRepo.Object);

            // Act
            var result = service.GetCustomerName(1);

            // Assert
            Assert.That( result,Is.EqualTo("John"));

            // Verify repo method was called exactly once
            mockRepo.Verify(r => r.GetCustomerById(1), Times.Once);
        }
    }
}
