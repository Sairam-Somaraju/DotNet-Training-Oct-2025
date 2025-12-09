using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Serialization;
using System.Runtime.Remoting.Channels.Tcp;
using remotinglib2;

namespace ServerApp2
{
    internal class Program
    {
        public static void Main()
        {
            TcpChannel channel = new TcpChannel(8085);
            ChannelServices.RegisterChannel(channel, false);

            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(ServiceClass),
                "StudentService",
                WellKnownObjectMode.Singleton);

            Console.WriteLine("Server Started on tcp://localhost:8085/StudentService");
            Console.ReadLine();
        }
    }
}
