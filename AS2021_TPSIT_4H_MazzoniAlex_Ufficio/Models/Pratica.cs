using System;
using System.Collections.Generic;
using System.Text;

namespace AS2021_TPSIT_4H_MazzoniAlex_Ufficio.Models
{
    class Pratica
    {
        string _nome;
        public string Nome { get => _nome; set => _nome = value; }

        string _cognome;
        public string Cognome { get => _cognome; set => _cognome = value; }

        string _codice;
        public string Codice { get =>_codice; set => _codice = value; }

        string _tipo;
        public string Tipo { get => _tipo; set =>_tipo=value; }

        string _descrizione;
        public string Descrizione { get => _descrizione; set => _descrizione = value; }

        int _numeroutente;
        public int NumeroUtente { get => _numeroutente; set => _numeroutente = value; }

        public Pratica(string nome, string cognome,string codice, string tipo, string descrizione, int numutente)
        {
            _nome = nome;
            _cognome = cognome;
            _codice = codice;
            _tipo = tipo;
            _descrizione = descrizione;
            _numeroutente = numutente;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nome:\t\t\t{_nome}");
            sb.AppendLine($"Cognome:\t\t{_cognome}");
            sb.AppendLine($"Tipo:\t\t\t{_tipo}");
            sb.AppendLine($"Descrizione:{_descrizione}");
            sb.AppendLine($"Cod.Numerico:{_codice}");
            sb.AppendLine($"Utente n:{_numeroutente}");

            return sb.ToString();
        }
    }
}
