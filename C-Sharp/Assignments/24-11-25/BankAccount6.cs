using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_11_25
{ 
    class IEnumarableTest
    {
        public decimal Balance { get; private set; }
        public List<string> History { get; } = new List<string>();

        public IEnumarableTest(decimal openingBalance)
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
    internal class BankAccount6
    {
        public static IEnumerable<object[]> WithdrawalCases()
        {
            yield return new object[] { 1000m, 200m, 800m };
            yield return new object[] { 500m, 100m, 400m };
            yield return new object[] { 250m, 50m, 200m };

        }
        [TestCaseSource(nameof(WithdrawalCases))]
        public void withdraw(decimal openingBalance, decimal amount, decimal expectedBalance)
        {
            IEnumarableTest test=new IEnumarableTest(openingBalance);

            test.Withdraw(amount);

            Assert.That(test.Balance, Is.EqualTo(expectedBalance));
        }
    }
}
