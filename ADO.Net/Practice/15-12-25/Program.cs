using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_12_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CRUDDemo demo= new CRUDDemo();
            //demo.Display();
            demo.Insert();

            CodeFirstDemo demo1 = new CodeFirstDemo();
            demo1.insertnewstudents();

            Console.ReadLine();

        }
    }
}
