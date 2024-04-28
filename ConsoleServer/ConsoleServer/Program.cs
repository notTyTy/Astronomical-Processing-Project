using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleServer
{
    internal class MyServerProgram
    {
        static void Main()
        {
            string address = "net.pipe://localhost/netpipeAstro";
            ServiceHost serviceHost = new ServiceHost(typeof(AstroServer));
            NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            serviceHost.AddServiceEndpoint(typeof(IAstroContract), binding, address);
            serviceHost.Open();
            Console.WriteLine("ServiceHost is running. Press <<Return>> to Exit");
            Console.ReadLine();
            serviceHost.Close();
        }
    }
}
