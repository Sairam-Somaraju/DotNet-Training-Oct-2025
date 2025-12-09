using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace _20_11_25
{
    internal class LSPMainMethod
    {
        public static void Main(string[] args)
        {
            PermanentEmployee perm = new PermanentEmployee();
            ContractEmployee contract = new ContractEmployee();

            WriteLine("Permanent Employee Bonus: " + perm.GetBonus(50000));
            WriteLine(contract.GetBonus(10000));

            Console.ReadLine();
        }
    }
}
