using System;
using System.Collections.Generic;
using System.Text;

namespace AddaDiLeonardo.Database.Classes
{
    public class Sezione
    {
        public string Titolo { get; set; }

        public List<string> Contenuto { get; set; } = new List<string>();
    }
}
