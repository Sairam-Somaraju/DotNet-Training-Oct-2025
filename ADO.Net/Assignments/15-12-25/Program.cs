using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CRUD c=new CRUD();
            c.insertnewEmployees();
             c.ShowAllEmployees();
            c.UpdateEmployee();
            c.DeleteEmployeeRecord();
            Console.ReadLine();
        }
    }
}
