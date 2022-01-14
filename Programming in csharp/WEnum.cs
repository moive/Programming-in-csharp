using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_in_csharp
{
    enum OperationStatus
    {
        Succesfull = 1,
        CustomerNotFound = 2,
        SystemError = 5
    }

    internal class WEnum
    {
        public WEnum()
        {
            int operationStatus = 5;

            if (operationStatus == (int)OperationStatus.Succesfull)
            {
                Console.WriteLine(nameof(OperationStatus.Succesfull));
            }
            else if (operationStatus == (int)OperationStatus.CustomerNotFound)
            {
                Console.WriteLine(nameof(OperationStatus.CustomerNotFound));
            }
            else if (operationStatus == (int)OperationStatus.SystemError)
            {
                Console.WriteLine(Enum.GetName(typeof(OperationStatus),5));
            }
        }
    }
}
