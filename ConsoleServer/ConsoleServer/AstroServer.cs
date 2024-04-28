using AstroMath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleServer
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    internal class AstroServer : IAstroContract
    {
        StarCalculations starCalculations = new StarCalculations();

        public double StarVelocity(double observed, double rest)
        {
            return starCalculations.StarVelocity(observed, rest);
        }

        public double StarDistance(double arcSecondsAngle)
        {
            return starCalculations.StarDistance(arcSecondsAngle);
        }

        public double TemperatureK(double celsius)
        {
            return starCalculations.TemperatureK(celsius);
        }

        public double EventHorizon(double mass)
        {
            return starCalculations.EventHorizon(mass);
        }
    }
}
