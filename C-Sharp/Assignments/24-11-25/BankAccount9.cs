using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_11_25
{
    public class InterestCalculation
    {
        public decimal Balance { get; private set; }
        
        public InterestCalculation(decimal balance)
        {
            this.Balance = balance;
        }
        public void ApplyInterest(decimal rate)
        {
            Balance += Balance * rate;
        }
    }
    internal class BankAccount9
    {
        [Test]
        public void TestInterest()
        {
            InterestCalculation calculation = new InterestCalculation(1000);
            calculation.ApplyInterest(0.05m);

            Assert.That(1050,Is.EqualTo(calculation.Balance));

        }
    }
}
