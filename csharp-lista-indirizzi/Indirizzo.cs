using System;
using System.Xml.Linq;


//In questo esercizio dovrete leggere un file CSV, che cambia poco da quanto appena visto nel live-coding in classe, e salvare tutti gli indirizzi contenuti al sul interno all’interno di una lista di oggetti istanziati a partire dalla classe Indirizzo.
//Attenzione: gli ultimi 3 indirizzi presentano dei possibili “casi particolari” che possono accadere a questo genere di file: vi chiedo di pensarci e di gestire come meglio crediate queste casistiche.

namespace csharp_lista_indirizzi
{
	public class Indirizzo
	{

        public string Name { get; init; }
        public string Cognome { get; init; }
        public string Via { get; init; }
        public string Citta { get; init; }
        public string Provincia { get; init; }
        public string CodicePostale { get; init; }


        public Indirizzo(string name, string cognome, string via, string citta, string provincia, string codicePostale)
        {
            Name = name;
            Cognome = cognome;
            Via = via;
            Citta = citta;
            Provincia = provincia;
            CodicePostale = codicePostale;
        }
    }
}

