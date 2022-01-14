using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_in_csharp
{
    internal class TryCatch
    {
        public TryCatch()
        {
            int a = 6;
            int b = 0;

            try
            {
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("DivideByZeroException: " + e);
            }
            catch (Exception ex)
            {
                Console.WriteLine("There has been an error: " + ex);
            }
            finally {
                Console.WriteLine("");
                Console.WriteLine("Will always run");
            }
        }
    }
}
