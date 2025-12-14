using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_12_2025
{
    internal class EntityMainMethod
    {
        public static void Main(string[] args)
        {
            EntityFrameworkDemo demo1 = new EntityFrameworkDemo();
            //demo1.showallEmployees();
            // demo1.SearchRecord();
            //demo1.AddRecord();
            //  demo1.DeleteRecord();
            demo1.UpdateRecord();
            Console.ReadLine();
        }
    }
}
