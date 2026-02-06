using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm_use_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AtmService op1 = new AtmService();
            op1.RetragereCash(1234, 200, true);

            Console.ReadKey();
        }
    }
}
