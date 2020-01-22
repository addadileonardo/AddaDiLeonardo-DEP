using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddaDiLeonardo.Database.Classes
{
    [Table(nameof(Sezione))]
    public class Sezione
    {
        public int ID { get; set; }

        public int IDTappa { get; set; }

        public string Titolo { get; set; }

    }
}
