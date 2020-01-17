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
            
            imgTappa.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Ponte.Ponte.jpg");
            iconMarker.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Icons.marker.png");
            imgSection2.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Tappa1.adda.jpg");
            imgSection3.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Tappa1.adda.jpg");
            imgSection4.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Tappa1.adda.jpg");
            imgSection5.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Tappa1.adda.jpg");

            //image section 1
            imgSection1.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Tappa1.adda.jpg");
            imgSection1_1.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Tappa1.adda.jpg");
            imgSection1_2.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Tappa1.adda.jpg");


            }

    }
}