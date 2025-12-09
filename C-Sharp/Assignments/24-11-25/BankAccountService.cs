using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace _24_11_25
{
    public class BankAccounts
    {
        public decimal Balance { get; private set; }

        public BankAccounts(decimal openingBalance)
        {
            Balance = openingBalance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
                throw new InvalidOperationException("Insufficient funds");
            Balance -= amount;
        }
    }
    [TestFixture]
    internal class BankAccountService
    {
        [Test]
        public void Withdraw_SubtractsAmountFromBalance()
        {
            decimal openingBalance = 500m;
            decimal withdrawAmount = 300m;
            var account = new BankAccounts(openingBalance);

            // Act
            account.Withdraw(withdrawAmount);

            // Assert
            Assert.That(account.Balance, Is.EqualTo(200m));
        }

        [Test]
        public void Withdraw_MoreThanBalance_ThrowsException()
        {
            var account = new BankAccounts(500m);
             
            var ex = Assert.Throws<InvalidOperationException>(() => account.Withdraw(600m));
            Assert.That(ex.Message, Does.Contain("Insufficient funds"));
        }

    }
}
