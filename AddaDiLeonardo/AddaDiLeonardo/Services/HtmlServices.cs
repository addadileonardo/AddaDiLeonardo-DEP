using AddaDiLeonardo.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Reflection;

namespace AddaDiLeonardo.Services
{
    public class HtmlServices : IHtmlServices
    {
        /// <summary>
        /// Restituisce l'html
        /// </summary>
        /// <param name="NomeTappa">Nome della tappa es: "Ponte"</param>
        /// <param name="NomeFile">Nome del file es: "Ponte_Intro.html"</param>
        /// <returns></returns>
        public string GetHtml(string NomeTappa, string NomeFile)
        {
            Assembly assembly = default(Assembly);
            switch (NomeTappa)
            {
                case "Ponte": assembly = typeof(TappaPonte).GetTypeInfo().Assembly; break;
                case "Rocchetta":break;
                case "Centrali":break;
                case "Fiume":break;
                case "Traghetto":break;
            }
            string html = default(string);
            Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.Files.{NomeTappa}.{NomeFile}");
            using (var reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }
            return html;
        }
    }
}
