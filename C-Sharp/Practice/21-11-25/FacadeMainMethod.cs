using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_25
{
    internal class FacadeMainMethod
    {
        public static void Main(string[] args)
        {
            login ob = new login();
            product p = new product();
            makepayment m = new makepayment();
            sendmail s = new sendmail();

            // second time
            facedpattern ob1 = new facedpattern();
            ob1.buyproduct();
        }

    }
}
