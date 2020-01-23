using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddaDiLeonardo.Database.Classes
{
    [Table(nameof(Contenuto))]
    public class Contenuto
    {
        public int ID { get; set; }

        public int IDSezione { get; set; }

        public int Indice { get; set; }

        public string Testo { get; set; }
    }
}
