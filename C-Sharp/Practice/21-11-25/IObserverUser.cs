using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_25
{
    internal class IObserverUser:IObserver
    {
        private string _name;

        public IObserverUser(string name)
        {
            _name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"{_name} received update: {message}");
        }
    }
}
