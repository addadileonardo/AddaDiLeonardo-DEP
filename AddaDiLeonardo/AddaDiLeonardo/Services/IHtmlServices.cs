using System;
using System.Collections.Generic;
using System.Text;

namespace AddaDiLeonardo.Services
{
    public interface IHtmlServices
    {
        /// <summary>
        /// Restituisce l'html
        /// </summary>
        /// <param name="NomeTappa">Nome della tappa es: "Ponte"</param>
        /// <param name="NomeFile">Nome del file es: "Ponte_Intro.html"</param>
        /// <returns></returns>
        string GetHtml(string NomeTappa, string NomeFile);
    }
}
