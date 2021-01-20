using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace AS2021_TPSIT_4H_MazzoniAlex_Ufficio.Models
{
    class UfficioPratiche
    {
        List<Pratica> _pratiche = new List<Pratica>();
        public UfficioPratiche()
        {
            _pratiche = new List<Pratica>
            {
                new Pratica("Alex", "Mazzoni", "COD1", "A", "Rtx 3070 FE", 1),
                new Pratica("Carlo", "Magno", "COD2", "B", "tesla model x", 2),
                new Pratica("Luigi", "XVI", "CODM", "C", "che bella la tesla", 3),
                new Pratica("Nicola", "Venaio", "COD5", "D", "la roadster soprattutto", 4)
            };
        }

            public void InserisciPratica(string nome, string cognome, string codice, string tipo, string descrizione)
            {
            int numutenti = _pratiche.Count + 1;
            _pratiche.Add(new Pratica(nome, cognome, codice, tipo, descrizione, numutenti));
            }
        public string RecuperoPraticadaTipo(string tipo)
        {
            List<Pratica> ListaPraticheTipo = new List<Pratica>();

            for (int i = 0; i < _pratiche.Count; i++)
                if (_pratiche[i].Tipo == tipo)
                    ListaPraticheTipo.Add(_pratiche[i]);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < ListaPraticheTipo.Count; i++)
                sb.AppendLine(ListaPraticheTipo[i].ToString());

            return sb.ToString();
        }

        public Pratica RecuperoPraticadaCodice(string codice)
        {
            for (int i = 0; i < _pratiche.Count; i++)
                if (_pratiche[i].Codice == codice)
                    return _pratiche[i];

            throw new Exception("La pratica non è stato trovata!");
        }
        public string ListaPratiche()
        {
            Console.WriteLine("Lista Pratiche:\n");
            List<Pratica> ListaUtenti = new List<Pratica>();
            for (int i = 0; i < _pratiche.Count; i++)
                ListaUtenti.Add(_pratiche[i]);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < ListaUtenti.Count; i++)
                sb.AppendLine(ListaUtenti[i].ToString());

            return sb.ToString();
        }

        public bool EliminazionePratica(string codice) 
        { 
            for (int i = 0; i < _pratiche.Count; i++) 
                if (_pratiche[i].Codice == codice) 
                { 
                    _pratiche.RemoveAt(i); 
                    return true;
                } 
            return false; 
        }
        public void SalvataggioDati()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\t\tLISTA PRATICHE\t{DateTime.Today:dd/MM/yyyy}");
            for (int i = 0; i < _pratiche.Count; i++)
                sb.AppendLine(_pratiche[i].ToString());

            File.AppendAllText("ListaPratiche.txt", sb.ToString());
        }
    }
}
