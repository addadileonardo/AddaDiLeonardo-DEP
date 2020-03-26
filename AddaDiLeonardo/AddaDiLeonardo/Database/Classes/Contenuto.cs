using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddaDiLeonardo.Database.Classes
{
    [Table("Contenuti")]
    public class Contenuto
    {
        public int Sezione { get; set; }

        public int Indice { get; set; }

        public string Testo { get; set; }
    }
}
