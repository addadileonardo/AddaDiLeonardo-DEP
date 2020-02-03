using AddaDiLeonardo.Database.Classes;
using AddaDiLeonardo.Services;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AddaDiLeonardo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TappaPonte : ContentPage
    {
        public TappaPonte()
        {
            InitializeComponent();

            int IDTappa = 1;
            Tappa tappa;
            List<Sezione> Sezioni;
            List<Contenuto> Contenuti;


            var db = App.Database;

            var list = db.GetAllTablesAsync().Result;

            tappa = db.GetTappaAsync(IDTappa).Result;
            Sezioni = db.GetSezioneAsync(IDTappa).Result;

            //var result = db.GetTesto();
            //per ogni sezioni leggi i contenuti
            //Contenuti = db.GetContenutoAsync(Sezioni[0].ID).Result;


            //var r = db.GetTesto().Result;

            #region INTRODUZIONE

            imgTappa.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Ponte.Ponte.jpg");
            iconMarker.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Icons.pin.png");
            lblTitolo.Text = tappa.Titolo;
            lblSottotitolo.Text = tappa.Sottotitolo;
            lblDescrizione.Text = tappa.Descrizione;

            #endregion

            #region SECTION 1

            Accordion0.Title = Sezioni[0].Titolo;
            Contenuti = db.GetContenutoAsync(Sezioni[0].ID).Result.OrderBy(c => c.Indice).ToList();

            imgSection1.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Tappa1.adda.jpg");
            lblSection1_1.Text = Contenuti[0].Testo;
            imgSection1_2.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Tappa1.adda.jpg");
            lblSection1_2.Text = Contenuti[1].Testo;
            imgSection1_3.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Tappa1.adda.jpg");
            lblSection1_3.Text = Contenuti[2].Testo;

            #endregion

            #region SECTION 2

            imgSection2.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Tappa1.adda.jpg");

            #endregion

            #region SECTION 3

            imgSection3.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Tappa1.adda.jpg");

            #endregion

            #region SECTION 4 

            imgSection4.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Tappa1.adda.jpg");

            #endregion

            #region SECTION 5

            imgSection5.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Tappa1.adda.jpg");

            #endregion+
        }

    }
}