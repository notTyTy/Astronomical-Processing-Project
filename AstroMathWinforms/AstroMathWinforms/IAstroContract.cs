using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

/* 
 * 1. Create the ServiceContract called “IAstroContract.cs”
 * which will need to be identical to the server without a reference to the AstroMath.DLL. 
*/
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
