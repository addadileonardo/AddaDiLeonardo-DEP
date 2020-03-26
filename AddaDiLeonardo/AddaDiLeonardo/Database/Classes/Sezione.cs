using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddaDiLeonardo.Database.Classes
{
    [Table("Sezioni")]
    public class Sezione
    {
        public int Id { get; set; }

        public int Tappa { get; set; }

        public string Titolo { get; set; }

    }
}
