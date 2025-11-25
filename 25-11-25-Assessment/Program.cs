using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_11_25_Assessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEmployeeDataReader reader = new MockEmployeeDataReader();
            PayrollProcessor payroll = new PayrollProcessor(reader);

            int[] ids = { 101, 102, 103, 999 };

            foreach (int id in ids)
            {
                decimal total = payroll.CalculateTotalCompensation(id);
                Console.WriteLine($"Employee {id} Composition is --> {total}");
            }

            Console.ReadLine();

        }
    }
}
