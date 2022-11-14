using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<Dipartimento, List<string>>> Anagrafica =
                     new Dictionary<string, Dictionary<Dipartimento, List<string>>>();


            Anagrafica.Add("DLA464683889C78", new Dictionary<Dipartimento, List<string>>());
            Anagrafica.Add("MLA4646t7689C73", new Dictionary<Dipartimento, List<string>>());
            Anagrafica.Add("OUA464683889C55", new Dictionary<Dipartimento, List<string>>());
            Anagrafica.Add("RTA464563824J23", new Dictionary<Dipartimento, List<string>>());


            Anagrafica["DLA464683889C78"].Add(Dipartimento.Asl, new List<string>());
            Anagrafica["DLA464683889C78"].Add(Dipartimento.Comune, new List<string>());
            Anagrafica["DLA464683889C78"].Add(Dipartimento.Polizia, new List<string>());
            Anagrafica["DLA464683889C78"].Add(Dipartimento.Inps, new List<string>());
            Anagrafica["DLA464683889C78"].Add(Dipartimento.Scuola, new List<string>());

            if (Anagrafica["DLA464683889C78"].ContainsKey(Dipartimento.Asl))
            {
                Anagrafica["DLA464683889C78"][Dipartimento.Asl].Add("Medico: Dr.Serrano");
            }
            else
            {
                Console.WriteLine("DLA464683889C78 was not exist");
            }
            if (Anagrafica["DLA464683889C78"].ContainsKey(Dipartimento.Comune))
            {
                Anagrafica["DLA464683889C78"][Dipartimento.Comune].Add("Reseidenza: Via.Barbadori");
            }
            else
            {
                Console.WriteLine("DLA464683889C78 was not exist");
            }
            if (Anagrafica["DLA464683889C78"].ContainsKey(Dipartimento.Polizia))
            {
                Anagrafica["DLA464683889C78"][Dipartimento.Polizia].Add("Senza Multa");
            }
            else
            {
                Console.WriteLine("DLA464683889C78 was not exist");
            }
            if (Anagrafica["DLA464683889C78"].ContainsKey(Dipartimento.Inps))
            {
                Anagrafica["DLA464683889C78"][Dipartimento.Inps].Add("Stato contributo: Pagato");
            }
            else
            {
                Console.WriteLine("DLA464683889C78 was not exist");
            }
            if (Anagrafica["DLA464683889C78"].ContainsKey(Dipartimento.Scuola))
            {
                Anagrafica["DLA464683889C78"][Dipartimento.Scuola].Add("Titolo di studi: Laurea Magistrale");

            }
            else
            {
                Console.WriteLine("DLA464683889C78 was not exist");
            }


            Console.WriteLine("All department in Italy: ");
            foreach (var item in Anagrafica["DLA464683889C78"].Keys)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Codice Fiscale:");
            int i = 1;
            foreach (var item in Anagrafica.Keys)
            {
                Console.WriteLine(i++ + ") " + item);
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine("For citizen with this Codice Fiscale DLA464683889C78 we found this information: ");
            Console.WriteLine();
            foreach (var item in Anagrafica["DLA464683889C78"][Dipartimento.Asl])
            {
                Console.WriteLine(item);
            }
            foreach (var item in Anagrafica["DLA464683889C78"][Dipartimento.Comune])
            {
                Console.WriteLine(item);
            }
            foreach (var item in Anagrafica["DLA464683889C78"][Dipartimento.Polizia])
            {
                Console.WriteLine(item);
            }
            foreach (var item in Anagrafica["DLA464683889C78"][Dipartimento.Inps])
            {
                Console.WriteLine(item);
            }
            foreach (var item in Anagrafica["DLA464683889C78"][Dipartimento.Scuola])
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
    public enum Dipartimento
    {
        Asl,
        Comune,
        Polizia,
        Inps,
        Scuola
    }
    
}
