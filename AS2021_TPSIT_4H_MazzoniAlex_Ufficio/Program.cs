using System;
using AS2021_TPSIT_4H_MazzoniAlex_Ufficio.Models;

namespace AS2021_TPSIT_4H_MazzoniAlex_Ufficio
{
    class Program
    {
        static void Main(string[] args)
        {
            UfficioPratiche ufficio = new UfficioPratiche();

            Console.WriteLine("Inserisco nuova Pratica...\n");
            ufficio.InserisciPratica("Gino", "Piccolo", "CODZ", "D", "Latte Scauduto");

            Console.WriteLine("----------------------------------------");
            //questo non trova
            try
            {
                Console.WriteLine(ufficio.RecuperoPraticadaCodice("COD4"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("----------------------------------------");
            //questo trova
            try
            {
                Console.WriteLine(ufficio.RecuperoPraticadaCodice("COD1"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("----------------------------------------");
            //ricerca per tipo
            try
            {
                Console.WriteLine(ufficio.RecuperoPraticadaTipo("D"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("----------------------------------------");

            ufficio.EliminazionePratica("CODM");

            Console.WriteLine("----------------------------------------");
            try
            {
                Console.WriteLine(ufficio.ListaPratiche());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            ufficio.SalvataggioDati();
        }
    }
}
