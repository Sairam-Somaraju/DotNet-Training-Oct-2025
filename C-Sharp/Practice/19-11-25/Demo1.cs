using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static _19_11_25.delegatedemo;

namespace _19_11_25
{
     
        public delegate void Greetdelegate();

     internal class Demo1
    {
        public static void SayHello()
        {
            Console.WriteLine("Good Morning");
        }
        public static void SayGoodBye()
        {
            Console.WriteLine("Good Bye...");
        }
        static void Main(string[] args)
        {
            Greetdelegate gd=SayHello;
            gd();
            gd=SayGoodBye;
            gd();
        }
    }
}
