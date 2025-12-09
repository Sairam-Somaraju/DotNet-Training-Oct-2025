using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_11_25
{
    public delegate void ss();
    internal class Demo4
    {
        public static void Main(string[] args)
        {
            Action<string> greet = name =>
            {
                Console.WriteLine(name);
            };
            greet("sai");

            ss s = delegate ()
            {
                Console.WriteLine("ss");
            };
            s();


        }
     }
    
}
