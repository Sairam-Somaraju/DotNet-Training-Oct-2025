using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_11_25
{
    internal class CallbyValue_Reference
    {
        public static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 20;
            Console.WriteLine("\n --------Call by value Demo-------");
            Console.WriteLine("Before calling the value: "+n1);
            methodValue(n1);
            Console.WriteLine("After calling the method value is: " + n1);
            

            Console.WriteLine("\n -------Call by Reference Demo-------");
            Console.WriteLine("Before calling the refrence value: "+n2);
            methodRef(ref n2);
            Console.WriteLine("After Calling the reference value is: "+n2);
        }
        public static void methodValue(int n1)
        {
            n1 += 50;
            Console.WriteLine("methodValue is: "+n1);
        }

        public static void methodRef(ref int n2)
        {
            n2 += 60;
                Console.WriteLine("methodreference value is: "+n2);
        }
    }
}
