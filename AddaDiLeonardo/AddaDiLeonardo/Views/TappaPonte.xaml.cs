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
            HtmlServices _htmlServices = new HtmlServices();

            imgTappa.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Ponte.Ponte.jpg");
            imgSection1.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Tappa1.adda.jpg");


            webIntro.Source = new HtmlWebViewSource()
            {
                Html = _htmlServices.GetHtml("Ponte", "Ponte_Intro.html")
            };

            webSection1.Source = new HtmlWebViewSource()
            {
                BaseUrl = DependencyService.Get<IBaseUrl>().Get(),
                Html = _htmlServices.GetHtml("Ponte", "Ponte_section_1.html")
            };
        }
    }
}