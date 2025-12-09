using System;

namespace _11_11_25
{
    class BankAccount
    {
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }
        public string lastOperator = "";

        public BankAccount(string accountNumber, string accountHolder, decimal balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public static BankAccount operator +(BankAccount a, BankAccount b)
        {
            BankAccount result = new BankAccount(
                a.AccountNumber + " & " + b.AccountNumber,
                a.AccountHolder + " & " + b.AccountHolder,
                a.Balance + b.Balance);

            result.lastOperator = "+ (After adding two bank accounts' balances)";
            return result;
        }

        public static BankAccount operator -(BankAccount a, BankAccount b)
        {
            BankAccount result = new BankAccount(
                a.AccountNumber + " - " + b.AccountNumber,
                a.AccountHolder + " - " + b.AccountHolder,
                a.Balance - b.Balance);

            result.lastOperator = "- (After subtracting balances of two bank accounts)";
            return result;
        }

        public static bool operator ==(BankAccount a, BankAccount b)
        {
            return (a.Balance == b.Balance);
        }

        public static bool operator !=(BankAccount a, BankAccount b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if (obj is BankAccount other)
            {
                return this.Balance == other.Balance;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Balance.GetHashCode();
        }
        public override string ToString()
        {
            return $"Account Holder: {AccountHolder}\nAccount Number: {AccountNumber}\nBalance: {Balance}\nLast Operation: {lastOperator}\n";
        }
    }

    internal class MiniBankingSystem
    {
        static void Main(string[] args)
        {
            BankAccount BankAccount1 = new BankAccount("AC7025", "Sairam", 15000);
            BankAccount BankAccount2 = new BankAccount("AC9966", "Venkat", 10000);

            BankAccount sum = BankAccount1 + BankAccount2;
            BankAccount sub = BankAccount1 - BankAccount2;

            Console.WriteLine(sum);
            Console.WriteLine(sub);
            Console.WriteLine($"BankAccount1 == BankAccount2: {BankAccount1 == BankAccount2}");
            Console.WriteLine($"BankAccount1 != BankAccount2: {BankAccount1 != BankAccount2}");
            Console.WriteLine($"Equals Method: {BankAccount1.Equals(BankAccount2)}");

            Console.ReadLine();
        }
    }
}
