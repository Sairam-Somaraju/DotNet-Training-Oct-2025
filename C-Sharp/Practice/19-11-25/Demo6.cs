using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_11_25
{
     
    public delegate Boolean Check(int x);
    internal class Demo6
    {
        public static Boolean IsEven(int x)
        {
            if(x%2==0) return true;
            return false;
        }
        public static Boolean IsPositive(int x)
        {
            if(x>0)
            {
                return true;
            }
            return false;
        }
        public static void Main(string[] args)
        {
            Check ch = IsEven;
            Console.WriteLine(ch(10));
            ch = IsPositive;
            Console.WriteLine(ch(-1));

 
        }
    }
}
