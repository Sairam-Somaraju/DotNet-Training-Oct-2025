using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_11_25
{
    public class Bankaccount
    {
        public decimal Balance { get; private set; }

        public Bankaccount(decimal balance)
        {
            this.Balance = balance;
        }
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
    }
    internal class BankAccountServices
    {
        [Test]
        public void Deposite()
        {
            decimal openingBalance = 1000m;
            decimal depositAmount = 200m;
            var account=new Bankaccount(openingBalance);
            account.Deposit(depositAmount);

            Assert.That(account.Balance, Is.EqualTo(1200m));
        }
    }
}
