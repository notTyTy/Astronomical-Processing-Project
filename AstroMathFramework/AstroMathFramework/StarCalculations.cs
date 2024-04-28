using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroMathFramework
{
    public class StarCalculations
    {
        static readonly int c = 299792458;

        public double StarVelocity(double observed, double rest)
        {
            double deltaWavelength = observed - rest;
            double velocity = c * (deltaWavelength / rest);

            return velocity;
        }

        public double StarDistance(double arcSecondsAngle)
        {
            double distance = 1 / arcSecondsAngle;
            return distance;
        }

        public double TemperatureK(double celsius)
        {
            double kelvin = 273 + celsius;
            return kelvin;
        }
        public double EventHorizon(double mass)
        {
            double gravityConst = 6.674 * Math.Pow(10, -11);
            double radius = (2 * gravityConst * mass) / Math.Pow(c, 2);
            return radius;
        }
    }
}
