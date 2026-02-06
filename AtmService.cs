using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm_use_case
{
    public class AtmService
    {
        // USE CASE de tip INCLUDE (o includem ca apel de metoda in metoda RetragereCash())
        // metoda RetragereCash() o apeleaza si se executa doar daca Autentificare returneaza True
        public bool Autentificare(int pin)
        {
            Console.WriteLine("[INCLUDE] >> Verificare cod PIN ...");
            return pin == 1234;
        }

        // USE CASE de tip EXTEND - optional (folosim IF pentru a o apela conditionat in RetragereCash)
        private void PrintareChitanta(double suma)
        {
            Console.WriteLine($"[EXTEND] S-a eliberat chitanta pentru suma de {suma} lei!");
        }

        // USE CASE PRINCIPAL
        public void RetragereCash(int pin, double suma, bool chitanta) 
        {
            Console.WriteLine("Initializare operatiune...\n");

            if (!(Autentificare(pin)))
            {
                Console.WriteLine("PIN incorect!");
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
