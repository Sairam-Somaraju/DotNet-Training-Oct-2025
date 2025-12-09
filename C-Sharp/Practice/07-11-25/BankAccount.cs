using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_11_25
{
    public abstract  class BankAccount
    {
        public string AccountNumber {  get; set; }
        public double Balance {  get; set; }
        public BankAccount(string accountNumber, double initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }
        public abstract void CalculateInterest();

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount}. New balance is {Balance} ");
        }
    }
}
