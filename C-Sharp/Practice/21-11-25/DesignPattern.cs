using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace _21_11_25
{
    internal class DesignPattern
    {
        static void Main(string[] args)
        {
            IUnityContainer u = new UnityContainer();
             
            u.RegisterType<Iservice, service>();

             var res = u.Resolve<Mathcls>();

            res.Show();

            Console.ReadLine();
        }
    }
}
