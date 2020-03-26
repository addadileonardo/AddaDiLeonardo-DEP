using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddaDiLeonardo.Database.Classes
{
    [Table("Tappe")]
    public class Tappa
    {
        public int Id { get; set; }

        public string Titolo { get; set; }

        public string Sottotitolo { get; set; }

        public string Descrizione { get; set; }

    }
}
