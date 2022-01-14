using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_in_csharp
{
    internal class WBreakContinue
    {
        public WBreakContinue()
        {
                int j=0;
            while (true)
            {
                Console.WriteLine(j);
                j++;
                Console.WriteLine("Press the key C if you want to cancel");
                var userReply = Console.ReadLine();
                if (userReply.ToUpper() == "C") break;
            }

        }
    }
}
