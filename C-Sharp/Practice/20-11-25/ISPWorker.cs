using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static _20_11_25.InterfacesForISP;

namespace _20_11_25
{
    internal class ISPWorker : IWork, IEat
    {
        public void Work()
        {
             WriteLine("Worker is working.");
        }

        public void Eat()
        {
             WriteLine("Worker is eating.");
        }
    }
}
