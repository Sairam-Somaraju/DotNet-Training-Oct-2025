using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_25
{
    internal class Mathcls
    {
        private readonly Iservice _service;

        // Constructor Injection
        public Mathcls(Iservice service)
        {
            _service = service;
        }

        public void Show()
        {
            Console.WriteLine("Mathcls Show method");
            _service.Display(); // calling service class method
        }
    }
}
