using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm_use_case
{
    public class AtmService
    {
        public bool Autentificare(int pin)
        {
            return pin == 1234;
        }

        private void PrintareChitanta(double suma)
        {
            Console.WriteLine($"S-a eliberat chitanta pentru suma de {suma} lei!");
        }

        public void RetragereCash(int pin, double suma, bool chitanta) 
        {

            if (!(Autentificare(pin)))
            {
                return;
            }

            Console.WriteLine($"Ai retras suma de {suma} lei!");

            if (chitanta)
            {
                PrintareChitanta(suma);
            }



        }


    }
}
