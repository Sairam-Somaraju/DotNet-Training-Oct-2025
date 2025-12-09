using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _20_11_25
{
    internal class ContractEmployee:EmployeeBase
    {
        public  String GetBonus(decimal salary)
        {
            return "Contract employee doesn't get bonus";
        }
    }
}
