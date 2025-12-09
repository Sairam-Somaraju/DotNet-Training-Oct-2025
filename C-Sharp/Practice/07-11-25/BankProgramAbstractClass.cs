using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_11_25
{
    internal class BankProgramAbstractClass
    {
        public static void Main(string[] args)
        {
            SavingsAccount savings = new SavingsAccount("SA123", 1000);
            savings.Deposit(500);
            savings.CalculateInterest();

            CurrentAccount currentAccount = new CurrentAccount("CA1123", 5000);
            currentAccount.Deposit(500);
            currentAccount.CalculateInterest();

           SealedClassDemo demo = new SealedClassDemo();
            demo.GetPersonalDetails();
            
        }
     }
}
