using remotingtrn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
//using System.Runtime.Remoting.Channels.Tcp;

namespace ClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HttpChannel channel = new HttpChannel();
            ChannelServices.RegisterChannel(channel, false);

            IMyinter ob = (IMyinter)Activator.GetObject(
                typeof(IMyinter),
                "http://localhost:8085/Hi");

            Console.WriteLine("Connected to remote object...");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            string result = ob.Show(name);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
