using remotinglib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp
{
    public class ServerClass
    {
        public static void Main()
        {
            HttpChannel channel = new HttpChannel(8085);
            ChannelServices.RegisterChannel(channel, false);

            // which object (service) clinent can access remotly

            RemotingConfiguration.RegisterWellKnownServiceType(
                 typeof(ServiceClass),   // your library class
                 "Hi",                   // unique object name
                 WellKnownObjectMode.Singleton);



            Console.WriteLine("Server started... Listening on port 8085");
            Console.WriteLine("Press ENTER to stop the server.");
            Console.Read();
        }
    }
}
