using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AstroMathWinforms
{
    [ServiceContract]
    internal interface IAstroContract
    {
        [OperationContract]
        double StarVelocity(double observed, double rest);

        [OperationContract]
        double StarDistance(double arcSecondsAngle);

        [OperationContract]
        double TemperatureK(double celsius);

        [OperationContract]
        double EventHorizon(double mass);

    }
}
