using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_11_25
{
    public class CurrentAccount: BankAccount
    {
        public CurrentAccount(string accountNumber, double initialBalance) : base(accountNumber, initialBalance)
        {

        }

        public override void CalculateInterest()
        {
            Console.WriteLine("Current accounts do not earn interest.");
        }
    }
}
