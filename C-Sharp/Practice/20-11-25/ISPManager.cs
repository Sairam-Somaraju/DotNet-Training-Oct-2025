using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static _20_11_25.InterfacesForISP;

namespace _20_11_25
{
    internal class ISPManager : IWork, IEat, IManageTeam
    {
        public void Work()
        {
             WriteLine("Manager is working.");
        }

        public void Eat()
        {
             WriteLine("Manager is eating.");
        }

        public void ManagesTeam()
        {
            WriteLine("Manager is managing the team.");
        }
    }
}
