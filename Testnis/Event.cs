using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testnis
{
    public class Event
    {
        public int EventId { get; set; }
        public string Navn { get; set; }
        public string Beskrivelse { get; set; }
        public DateTime StartDato { get; set; }
        public DateTime SlutDato { get; set; }

        //public List<Medlem> Tilmeldte { get; set; }

        public Event()
        {
            
        }

        public Event(int id, string navn, string beskrivelse, DateTime startDato, DateTime slutDato)
        {
            EventId = id;
            Navn = navn;
            Beskrivelse = beskrivelse;
            StartDato = startDato;
            SlutDato = slutDato;
            //Tilmeldte = tilmeldte;
        }

        public override string ToString()
        {
            return $"ID: {EventId}, Navn: {Navn}, Beskrivelse: {Beskrivelse}, Start Dato: {StartDato}, Slut Dato: {SlutDato}";
        }

    }
}
