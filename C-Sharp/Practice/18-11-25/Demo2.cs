using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_11_25
{
    internal class Demo2
    {
        public delegate string mydel();

        public object mymethod()
        {
            return "hello";
        }

        // Optional + Named parameters
        public void NamedoptionalDemo(int x = 10, int y = 30)
        {
            int result = x + y;
            Console.WriteLine($"The sum is {result}");
        }

        public void NamedoptionalDemo()
        {
            Console.WriteLine("Hello world");
        }

        public void CoVariance_Contravariance()
        {
            string[] st = { "hello", "welcome" };
            object[] o = st;  // Covariance for arrays

            IEnumerable<string> names = new List<string>();
            IEnumerable<object> objs = names; // Covariance for generics
        }

        public void dynamicdemo()
        {
            var a = 100; // compile time type
            dynamic m = 100;
            dynamic n = "hi";
            dynamic o = m * n;   // Runtime error but allowed during compilation
        }
    }

    // Delegates for Covariance/Contravariance
    public delegate object mydel();    // base type
    public delegate void mydel2(string st); // derived type

    class Program
    {
        public static string cov()  // derived return type (string)
        {
            return "hi from cov()";
        }

        public static void con(object st) // base parameter type
        {
            Console.WriteLine("con() method executed");
        }

        public static void hello()
        {
            // Covariance Example
            mydel d = cov;
            Console.WriteLine(d());

            // Contravariance Example
            mydel2 d2 = con;
            d2("hello");
        }

        // =================== MAIN METHOD ===================
        static void Main(string[] args)
        {
            Console.WriteLine("Program Started\n");

            Demo2 c = new Demo2();

            // Call whichever method you want to test:
            //c.NamedoptionalDemo();
            //c.NamedoptionalDemo(x: 20, y: 50);
            //c.dynamicdemo();
            //c.CoVariance_Contravariance();

            hello();   // Run covariance/contravariance example

            Console.WriteLine("\nProgram Finished");
        }
    }
}
