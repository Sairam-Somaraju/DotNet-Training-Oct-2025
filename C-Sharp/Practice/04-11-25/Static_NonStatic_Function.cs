using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_11_25
{
    internal class Static_NonStatic_Function
    {
        static int a;
        int b ;
        public static void staticMethod()
        {
            Console.WriteLine("It is a Static Method.");
        }
        public void nonStaticMethod()
        {
            Console.WriteLine("Non static method");
        }
        public static void Main(string[] args)
        {
            a = 100;
            // b= 90;// we can't access the non static variable inside the static method so we need to create object
            Static_NonStatic_Function  snf= new Static_NonStatic_Function();
            snf.b = 300;
            Console.WriteLine("Non static variable value is through object creation: "+snf.b);
            Console.WriteLine("Static variable value is: " + a);
            staticMethod();
            snf.nonStaticMethod();
            Console.ReadLine();
        }
    }
}
