using AddaDiLeonardo.Services;
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

            var db = App.Database;

            //db.CreateTable();

            int r = db.SaveItemAsync(new Database.Classes.Tappa()).Result;

            var tappe = db.GetItemsAsync().Result;

            string type = tappe.GetType().Name;
                                                     
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