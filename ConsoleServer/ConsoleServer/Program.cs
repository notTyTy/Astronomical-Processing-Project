using System;
using System.ServiceModel;

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
            Console.WriteLine("ServiceHost is now closed. Please relaunch the server when required.");
            serviceHost.Close();
        }
    }
}
