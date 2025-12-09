using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace _24_11_25
{
    public class BankAccoun
    {
        public decimal Balance { get; private set; }

        public BankAccoun(decimal openingBalance)
        {
            Balance = openingBalance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
    }
    [TestFixture]
    internal class BankAccount4
    {
        [TestCase(100, 50, 150)]
        [TestCase(0, 100, 100)]
        [TestCase(500, 0, 500)]
        public void Deposit_AddsAmountToBalance(decimal openingBalance, decimal depositAmount, decimal expectedBalance)
        {
            // Arrange
            var account = new BankAccoun(openingBalance);

            // Act
            account.Deposit(depositAmount);

            // Assert
            Assert.That(account.Balance, Is.EqualTo(expectedBalance));
        }
    }
}
