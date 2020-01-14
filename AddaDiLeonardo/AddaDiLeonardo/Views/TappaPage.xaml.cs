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
    public partial class TappaPage : ContentPage
    {
        public TappaPage()
        {
            InitializeComponent();

            imgTappa.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Tappa1.adda.jpg");
            //indicator1.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Icons.arrow.png");
            indicator2.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Icons.arrow.png");
            indicator3.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Icons.arrow.png");
            indicator4.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Icons.arrow.png");
        }
    }
}
