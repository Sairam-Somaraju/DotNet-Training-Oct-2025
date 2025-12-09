using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_11_25
{
    internal class ISPMainMethod
    {
        public static void Main(string[] args)
        {
            ISPWorker worker = new ISPWorker();
            ISPManager manager = new ISPManager();

            worker.Work();
            worker.Eat();

            manager.Work();
            manager.Eat();
            manager.ManagesTeam();

        }
    }
}
