using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_11_25
{
    internal class FakeClass:IMath
    {
        public string Add(int x, int y)
        {
            return "the sum is 30";
        }
    }
}
