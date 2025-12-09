using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_11_25
{
    public class IEnumarableTest2
    {
        public decimal Balance { get; private set; }
        public List<string> History { get; } = new List<string>();

        public IEnumarableTest2(decimal openingBalance)
        {
            Balance = openingBalance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            History.Add("Deposit " + amount);
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                throw new InvalidOperationException("Insufficient funds");
            }

            Balance -= amount;
            History.Add("Withdraw " + amount);
        }
    }
    internal class BankAccount8
    {
        [Test]
        public void Withdraw_MoreThanBalance()
        {
             decimal openingBalance = 500m;
            IEnumarableTest2 account = new IEnumarableTest2(openingBalance);

             InvalidOperationException ex =Assert.Throws<InvalidOperationException>(() => account.Withdraw(600m));

            // Assert:  correct exception message
            Assert.That(ex.Message, Is.EqualTo("Insufficient funds"));

            // Assert: balance stays unchanged
            Assert.That(account.Balance, Is.EqualTo(openingBalance));
        }
    }
}

