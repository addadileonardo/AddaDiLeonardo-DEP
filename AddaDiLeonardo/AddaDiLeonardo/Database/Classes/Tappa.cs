using System;
using System.Collections.Generic;
using System.Text;

namespace AddaDiLeonardo.Database.Classes
{
    public class Tappa
    {
        public int ID { get; set; }

        public string Titolo { get; set; }

        public string Sottotitolo { get; set; }

        public string Descrizione { get; set; }

        public List<Sezione> Sezioni { get; set; } = new List<Sezione>();


    }
}
