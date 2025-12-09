using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_11_25
{
    internal class PermanentEmployee : EmployeeBase, IBonusEligible
    {
        public decimal GetBonus(decimal salary)
        {
            return salary * 0.20m;
        }
    }
}
