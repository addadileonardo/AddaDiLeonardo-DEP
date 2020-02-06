using AddaDiLeonardo.Database.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AddaDiLeonardo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TappaRocchetta : ContentPage
    {
        public TappaRocchetta()
        {
            InitializeComponent();

            int IDTappa = 2;
            Tappa tappa;
            List<Sezione> Sezioni;
            List<Contenuto> Contenuti;

            var db = App.Database;

            tappa = db.GetTappaAsync(IDTappa).Result;
            Sezioni = db.GetSezioneAsync(IDTappa).Result;

            #region INTRODUZIONE

            imgTappa.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Rocchetta.img_tappa.jpg");
            iconMarker.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Icons.pin.png");
            lblTitolo.Text = tappa.Titolo;
            lblSottotitolo.Text = tappa.Sottotitolo;
            lblDescrizione.Text = tappa.Descrizione;

            #endregion

            #region SECTION 1

            Accordion0.Title = Sezioni[0].Titolo;
            Contenuti = db.GetContenutoAsync(Sezioni[0].ID).Result.OrderBy(c => c.Indice).ToList();

            imgSection1.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Rocchetta.fiume_3.JPG");
            //titolo: poetica del fiume, richiamo a sacro e femminile
            stackContenuto_0.Children.Add(new CustomLabelTitle { Text = Contenuti[0].Testo });
            //primo paragrafo

            //stackContenuto_0.Children.Add(new CustomLabel { Text = Contenuti[1].Testo });
            stackContenuto_0.Children.Add(FormattaContenuto(Contenuti[1].Testo));
            stackContenuto_0.Children.Add(FormattaContenuto(Contenuti[2].Testo));
            stackContenuto_0.Children.Add(FormattaContenuto(Contenuti[3].Testo));

            
            //titolo: Il fiume, dinamico e sacro
            stackContenuto_0.Children.Add(new CustomLabelTitle { Text = Contenuti[4].Testo });
            stackContenuto_0.Children.Add(new Image { Source = ImageSource.FromResource("AddaDiLeonardo.Images.Rocchetta.fiume_1.jpeg"), Aspect = Aspect.AspectFill, Margin = new Thickness(0,10,0,10) });
            //secondo paragrafo
            stackContenuto_0.Children.Add(FormattaContenuto(Contenuti[5].Testo));
            stackContenuto_0.Children.Add(FormattaContenuto(Contenuti[6].Testo));
            stackContenuto_0.Children.Add(FormattaContenuto(Contenuti[7].Testo));
            stackContenuto_0.Children.Add(FormattaContenuto(Contenuti[8].Testo));
            stackContenuto_0.Children.Add(FormattaContenuto(Contenuti[9].Testo));
            #endregion

            #region SECTION 2

            Accordion1.Title = Sezioni[1].Titolo;
            Contenuti = db.GetContenutoAsync(Sezioni[1].ID).Result.OrderBy(c => c.Indice).ToList();

            imgSection2.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Rocchetta.rocchetta_1.jpg");
            //titolo:La rocchetta luogo sacro e militare
            stackContenuto_1.Children.Add(new CustomLabelTitle { Text = Contenuti[0].Testo });
            stackContenuto_1.Children.Add(new CustomLabel { Text = Contenuti[1].Testo });
            stackContenuto_1.Children.Add(new CustomLabel { Text = Contenuti[2].Testo });
            stackContenuto_1.Children.Add(new CustomLabel { Text = Contenuti[3].Testo });

            //titolo: L'origine e la storia
            stackContenuto_1.Children.Add(new CustomLabelTitle { Text = Contenuti[4].Testo });
            stackContenuto_1.Children.Add(new Image { Source = ImageSource.FromResource("AddaDiLeonardo.Images.Rocchetta.rocchetta-ga.jpg"), Aspect = Aspect.AspectFill, Margin = new Thickness(0, 10, 0, 10) });
            stackContenuto_1.Children.Add(new CustomLabel { Text = Contenuti[5].Testo });
            stackContenuto_1.Children.Add(new CustomLabel { Text = Contenuti[6].Testo });
            stackContenuto_1.Children.Add(new CustomLabel { Text = Contenuti[7].Testo });
            stackContenuto_1.Children.Add(new CustomLabel { Text = Contenuti[8].Testo });
            stackContenuto_1.Children.Add(new CustomLabel { Text = Contenuti[9].Testo });

            #endregion

            #region SECTION 3

            Accordion2.Title = Sezioni[2].Titolo;
            Contenuti = db.GetContenutoAsync(Sezioni[2].ID).Result.OrderBy(c => c.Indice).ToList();

            //imgSection3.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Tappa1.adda.jpg"); //NO IMMAGINE??
            stackContenuto_2.Children.Add(new CustomLabelTitle { Text = Contenuti[0].Testo });
            stackContenuto_2.Children.Add(new CustomLabel { Text = Contenuti[1].Testo });
            stackContenuto_2.Children.Add(new CustomLabel { Text = Contenuti[2].Testo });
            stackContenuto_2.Children.Add(new CustomLabel { Text = Contenuti[3].Testo });
            stackContenuto_2.Children.Add(new CustomLabel { Text = Contenuti[4].Testo });

            #endregion

            #region SECTION 4

            Accordion3.Title = Sezioni[3].Titolo;
            Contenuti = db.GetContenutoAsync(Sezioni[3].ID).Result.OrderBy(c => c.Indice).ToList();

            imgSection4.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Rocchetta.tre_corni_privata.jpg");
            //titolo:Racconto del dipinto
            stackContenuto_3.Children.Add(new CustomLabel { Text = Contenuti[0].Testo });
            stackContenuto_3.Children.Add(new Image { Source = ImageSource.FromResource("AddaDiLeonardo.Images.Rocchetta.verg_rocce.jpg"), Aspect=Aspect.AspectFit, Margin = new Thickness(0,10,0,10) });
            stackContenuto_3.Children.Add(new CustomLabel { Text = Contenuti[1].Testo, FontSize=15});

            stackContenuto_3.Children.Add(new CustomLabel { Text = Contenuti[2].Testo });
            stackContenuto_3.Children.Add(new CustomLabelTitle { Text = Contenuti[3].Testo });
            stackContenuto_3.Children.Add(new CustomLabel { Text = Contenuti[4].Testo });
            stackContenuto_3.Children.Add(new CustomLabelTitle { Text = Contenuti[5].Testo });
            stackContenuto_3.Children.Add(new CustomLabel { Text = Contenuti[6].Testo });
            stackContenuto_3.Children.Add(new CustomLabelTitle { Text = Contenuti[7].Testo });
            stackContenuto_3.Children.Add(new CustomLabel { Text = Contenuti[8].Testo });
            stackContenuto_3.Children.Add(new CustomLabel { Text = Contenuti[9].Testo });
            stackContenuto_3.Children.Add(new CustomLabel { Text = Contenuti[10].Testo , FontAttributes = FontAttributes.Italic});
            #endregion

            #region SECTION 5

            Accordion4.Title = Sezioni[4].Titolo;
            Contenuti = db.GetContenutoAsync(Sezioni[4].ID).Result.OrderBy(c => c.Indice).ToList();

            imgSection5.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Tappa1.adda.jpg");

            #endregion
        }


        private CustomLabel FormattaContenuto(string contenuto)
        {
            CustomLabel label = new CustomLabel();
            FormattedString formatted = new FormattedString();
            if (contenuto.Contains("**"))
            {
                string[] splits = contenuto.Split('*');
                for (int x = 0; x < splits.Length; x++)
                {
                    Span span = new Span() { Text = splits[x] };
                    if (x == 0 || x == splits.Length - 1)
                    {
                        formatted.Spans.Add(span);
                        continue;
                    }

                    if (splits[x - 1] == "" && splits[x + 1] == "")
                    {
                        span.FontAttributes = FontAttributes.Bold;
                        span.ForegroundColor = Color.Black;
                    }
                    formatted.Spans.Add(span);
                }
                label.FormattedText = formatted;
            }
            else
                label.Text = contenuto;

            return label;
        }
    }
}