using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_11_25
{
    internal interface IBonusEligible
    {
        decimal GetBonus(decimal salary);
    }
}
