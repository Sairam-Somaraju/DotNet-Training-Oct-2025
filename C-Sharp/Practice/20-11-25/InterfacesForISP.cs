using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_11_25
{
    internal class InterfacesForISP
    {
        public interface IWork
        {
            void Work();
        }

        public interface IEat
        {
            void Eat();
        }

        public interface IManageTeam
        {
            void ManagesTeam();
        }

    }
}
