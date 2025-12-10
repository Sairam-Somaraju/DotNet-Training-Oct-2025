using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDoperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo dm= new Demo();
             //dm.AddEmployee();
           //dm.ShowEmployee();

           //dm.DeleteEmployee();
            dm.UpdateEmployee();
            Console.ReadLine();

        }
    }
}
