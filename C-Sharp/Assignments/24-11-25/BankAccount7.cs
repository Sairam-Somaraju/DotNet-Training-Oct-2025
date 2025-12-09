using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_11_25
{
    public class NegativeException
    {
        public void Negativeexception(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be Positive");
            }
        }
    }
    internal class BankAccount7
    {
        [Test]
        public void GetException()
        {
            NegativeException negative=new NegativeException();

             Assert.Throws<ArgumentException>(() => negative.Negativeexception(-100));
        }
    }
}
