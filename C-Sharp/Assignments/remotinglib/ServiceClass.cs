using remotingtrn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remotinglib
{
    public class ServiceClass : MarshalByRefObject, IMyinter
    {
        public string Show(string name)
        {
            Console.WriteLine($"Message Received from client is {name}");
            return $"Hello {name} How Are You!!";
        }
    }
}
