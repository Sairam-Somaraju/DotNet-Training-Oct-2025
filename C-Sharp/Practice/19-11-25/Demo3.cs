using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_11_25
{
    internal class Demo3
    {
        public delegate void anonymous( );

        public static void Main(string[] args)
        {
            anonymous an = delegate ()
            {
                Console.WriteLine("e");
            };
            an();
        }
    }
}
