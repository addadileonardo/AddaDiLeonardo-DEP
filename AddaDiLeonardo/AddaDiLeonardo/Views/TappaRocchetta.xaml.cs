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

            #region INTRODUZIONE

            imgTappa.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Rocchetta.IMG_9730.JPG");
            iconMarker.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Icons.marker.png");
            lblTitolo.Text = "Vergine delle rocce e Rocchetta";
            lblSottotitolo.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse pretium sit amet felis eu iaculis. Aliquam condimentum metus a felis luctus";
            lblDescrizione.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse pretium sit amet felis eu iaculis. Aliquam condimentum metus a felis luctus dignissim ac a est. Proin rhoncus ligula blandit, egestas lectus eget, dignissim ligula. Nunc tellus nunc, auctor sed ex vitae, feugiat iaculis tortor. Morbi ullamcorper tempus eros eu molestie. Aliquam erat volutpat. Donec sed fringilla ligula, vel euismod enim. Suspendisse non nunc pellentesque, pretium mi ut, suscipit tellus. Nulla tincidunt libero dui, laoreet ornare leo auctor non. In fermentum erat non ligula tempor faucibus. Vivamus at maximus justo. Nam lacinia lobortis nisi et volutpat. Quisque et lectus et velit convallis dapibus. Nunc lacinia vitae magna lacinia venenatis. Aliquam in nunc lacus.";

            #endregion

            #region SECTION 1

            //Accordion0.Title = Sezioni[0].Titolo;
            //Contenuti = db.GetContenutoAsync(Sezioni[0].ID).Result.OrderBy(c => c.Indice).ToList();

            imgSection1.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Tappa1.adda.jpg");
            lblSection1_1.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse pretium sit amet felis eu iaculis. Aliquam condimentum metus a felis luctus dignissim ac a est. Proin rhoncus ligula blandit, egestas lectus eget, dignissim ligula. Nunc tellus nunc, auctor sed ex vitae, feugiat iaculis tortor. Morbi ullamcorper tempus eros eu molestie. Aliquam erat volutpat. Donec sed fringilla ligula, vel euismod enim. Suspendisse non nunc pellentesque, pretium mi ut, suscipit tellus. Nulla tincidunt libero dui, laoreet ornare leo auctor non. In fermentum erat non ligula tempor faucibus. Vivamus at maximus justo. Nam lacinia lobortis nisi et volutpat. Quisque et lectus et velit convallis dapibus. Nunc lacinia vitae magna lacinia venenatis. Aliquam in nunc lacus.";

            #endregion

            #region SECTION 2

            imgSection2.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Tappa1.adda.jpg");

            #endregion
        }
    }
}