using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Console_Server_Testing
{
    internal class ClientProgram
    {
        static void Main()
        {
            string address = "net.pipe://localhost/netpipeAstro";
            NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            EndpointAddress ep = new EndpointAddress(address);
            IAstroContract astroContract =
            ChannelFactory<IAstroContract>.CreateChannel(binding, ep);

            Console.WriteLine(astroContract.TemperatureK(400.0));
            Console.ReadLine();
        }
    }
}
