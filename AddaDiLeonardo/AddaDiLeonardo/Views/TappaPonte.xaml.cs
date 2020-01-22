using AddaDiLeonardo.Database.Classes;
using AddaDiLeonardo.Services;
using System.Collections.Generic;
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

            int IDTappa = 99;
            Tappa tappa;
            List<Sezione> Sezioni;
            List<Contenuto> Contenuti;

            var db = App.Database;

            //Tappa tappa1 = new Tappa() { ID = 99, Titolo = "Tappa Test", Sottotitolo = "Test", Descrizione = "Test per provare i database" };
            //Sezione sezione1 = new Sezione() { ID = 991, IDTappa = 99, Titolo = "Sezione1" };
            //Contenuto contenuto1 = new Contenuto() { ID = 9911, IDSezione = 991, Indice = 1, Contentuto = "Contenuto 1 della sezione 1 della tappa 1" };

            //var t = db.CreateTableTappa().Result;
            //var s = db.CreateTableSezione().Result;
            //var c = db.CreateTableContenuto().Result;

            var list = db.GetAllTablesAsync().Result;

            //var nt = db.SaveContenutoAsync(contenuto1).Result;
            //var ns = db.SaveSezioneAsync(sezione1).Result;
            //var nc = db.SaveTappaAsync(tappa1).Result;

            tappa = db.GetTappaAsync(IDTappa).Result;
            Sezioni = db.GetSezioneAsync(IDTappa).Result;
            //per ogni sezioni leggi i contenuti
            Contenuti = db.GetContenutoAsync(Sezioni[0].ID).Result;
                                                     
            #region INTRODUZIONE

            imgTappa.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Ponte.Ponte.jpg");
            iconMarker.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Icons.marker.png");
            lblTitolo.Text = "Ponte San Michele";
            lblSottotitolo.Text = "Una delle più interessanti realizzazioni dell'ingegneria italiana nell'800, punto di unione tra le due sponde rivali dell'Adda.";
            lblDescrizione.Text = "Il Ponte San Michele, situato a Paderno d'Adda, è stato progettato dall'ingegnere svizzero Jules Röthlisberger nel 1889, come collegamento viabilistico e ferroviario tra l'area economica della bergamasca e quella milanese. La struttura e i numerosi eventi di cui è stato teatro l'hanno reso un'opera architettonica di grande importanza storica.";

            #endregion

            #region SECTION 1
         
            imgSection1.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Tappa1.adda.jpg");
            lblSection1_1.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse pretium sit amet felis eu iaculis. Aliquam condimentum metus a felis luctus dignissim ac a est. Proin rhoncus ligula blandit, egestas lectus eget, dignissim ligula. Nunc tellus nunc, auctor sed ex vitae, feugiat iaculis tortor. Morbi ullamcorper tempus eros eu molestie. Aliquam erat volutpat. Donec sed fringilla ligula, vel euismod enim. Suspendisse non nunc pellentesque, pretium mi ut, suscipit tellus. Nulla tincidunt libero dui, laoreet ornare leo auctor non. In fermentum erat non ligula tempor faucibus. Vivamus at maximus justo. Nam lacinia lobortis nisi et volutpat. Quisque et lectus et velit convallis dapibus. Nunc lacinia vitae magna lacinia venenatis. Aliquam in nunc lacus.";
            imgSection1_2.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Tappa1.adda.jpg");
            lblSection1_2.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse pretium sit amet felis eu iaculis. Aliquam condimentum metus a felis luctus dignissim ac a est. Proin rhoncus ligula blandit, egestas lectus eget, dignissim ligula. Nunc tellus nunc, auctor sed ex vitae, feugiat iaculis tortor. Morbi ullamcorper tempus eros eu molestie. Aliquam erat volutpat. Donec sed fringilla ligula, vel euismod enim. Suspendisse non nunc pellentesque, pretium mi ut, suscipit tellus. Nulla tincidunt libero dui, laoreet ornare leo auctor non. In fermentum erat non ligula tempor faucibus. Vivamus at maximus justo. Nam lacinia lobortis nisi et volutpat. Quisque et lectus et velit convallis dapibus. Nunc lacinia vitae magna lacinia venenatis. Aliquam in nunc lacus.";
            imgSection1_3.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Tappa1.adda.jpg");
            lblSection1_3.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse pretium sit amet felis eu iaculis. Aliquam condimentum metus a felis luctus dignissim ac a est. Proin rhoncus ligula blandit, egestas lectus eget, dignissim ligula. Nunc tellus nunc, auctor sed ex vitae, feugiat iaculis tortor. Morbi ullamcorper tempus eros eu molestie. Aliquam erat volutpat. Donec sed fringilla ligula, vel euismod enim. Suspendisse non nunc pellentesque, pretium mi ut, suscipit tellus. Nulla tincidunt libero dui, laoreet ornare leo auctor non. In fermentum erat non ligula tempor faucibus. Vivamus at maximus justo. Nam lacinia lobortis nisi et volutpat. Quisque et lectus et velit convallis dapibus. Nunc lacinia vitae magna lacinia venenatis. Aliquam in nunc lacus.";

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