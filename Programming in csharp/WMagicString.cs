using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    internal class WMagicString
    {
        public WMagicString()
        {
            string operationStatus = "K15";
            if (operationStatus == OperationsStatus._sucessfull)
            {
                //
            }
            else if (operationStatus == OperationsStatus._customerNotFound)
            {
                //
            }
            else if (operationStatus == OperationsStatus._systemError)
            {
                Console.WriteLine(OperationsStatus._systemError);
            }
        }
    }

    public static class OperationsStatus
    {
        public const string _sucessfull = "K120";
        public const string _customerNotFound = "P4";
        public const string _systemError = "K15";
    }
}
