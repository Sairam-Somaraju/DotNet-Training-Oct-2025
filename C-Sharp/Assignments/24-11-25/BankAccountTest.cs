using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_11_25
{
    public class BankAccount
    {
        public decimal Balance { get; private set; }

        public BankAccount(decimal openingBalance)
        {
            Balance = openingBalance;
        }

        internal void Withdraw(decimal withdrawAmount)
        {
            throw new NotImplementedException();
        }

        internal void Deposit(decimal depositAmount)
        {
            throw new NotImplementedException();
        }
    }
    internal class BankAccountTest
    {
        [Test]
        public void BankAccountBalance()
        {
            decimal openingBalance = 500m;

            var account=new BankAccount(openingBalance);

            Assert.That(account.Balance,Is.EqualTo(500m));
        }
    }
}
