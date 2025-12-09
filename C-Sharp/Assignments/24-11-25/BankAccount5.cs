using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_11_25
{
    public class TransactionHistory
    {
        public List<string> History { get; }=new List<string>();
        public decimal Balance { get; private set; }

        public TransactionHistory(decimal balance)
        {
            this.Balance = balance;
        }
        public void Deposite(decimal amount)
        {
            Balance += amount;
            History.Add("Deposite" + amount);
        }
    }
    internal class BankAccount5
    {
        [Test]
        public void GetBalance()
        {
            TransactionHistory history=new TransactionHistory(5000);
            history.Deposite(500);
            history.Deposite(1000);

            Assert.That(history.History.Count ,Is.EqualTo(2));
        }
    }
}
