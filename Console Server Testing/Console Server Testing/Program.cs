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

            // Server Testing
            Console.WriteLine("Star Velocity Input Parameters Test 1, Observed 500.1nm, Rest 500nm");
            Console.WriteLine(astroContract.StarVelocity(500.1, 500));
            Console.WriteLine("Star Velocity Input Parameters Test 2, Observed 500.1nm, Rest 500nm");
            Console.WriteLine(astroContract.StarVelocity(650.7, 650.4));
            Console.WriteLine("Star Distance Input Parameter Test 1, Arc Seconds Angle: 0.546");
            Console.WriteLine(astroContract.StarDistance(0.546));
            Console.WriteLine("Star Distance Input Parameter Test 2, Arc Seconds Angle: 0.982");
            Console.WriteLine(astroContract.StarDistance(0.982));
            Console.WriteLine("Temperature Input Parameter Test 2, Celsius: 546 degrees");
            Console.WriteLine(astroContract.TemperatureK(546));
            Console.WriteLine("Temperature Input Parameter Test 2, Celsius: 2678 degrees");
            Console.WriteLine(astroContract.TemperatureK(2678));
            Console.WriteLine("Event Horizon Input Parameter Test 2, Mass: 5.67x10^36");
            Console.WriteLine(astroContract.EventHorizon(5.67 * Math.Pow(10, 36)));
            Console.WriteLine("Event Horizon Input Parameter Test 2, Mass: 7.44x10^42");
            Console.WriteLine(astroContract.EventHorizon(7.44 * Math.Pow(10, 42)));
            
            Console.ReadLine();
        }
    }
}
