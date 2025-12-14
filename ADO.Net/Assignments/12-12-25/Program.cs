using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_12_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EntityFrameworkDemo efd=new EntityFrameworkDemo();
            efd.MatchingRecords();
            efd.displayDetails();
            efd.DisplaybyDate();
            efd.SalaryWithBonus();
            efd.InsertUpdate();
            efd.RecordDelete();
            Console.ReadLine();
        }
    }
}
