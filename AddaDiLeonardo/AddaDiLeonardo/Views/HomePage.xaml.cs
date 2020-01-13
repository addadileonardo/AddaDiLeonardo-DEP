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
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
            Immaginesfondo.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Prova3.png");
            Tappa1.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Fiume.jpg");
            Tappa2.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Tappa_ponte.jpg");
            Tappa3.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Centrale.jpg");
            Tappa4.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Vergine.jpg");
        }

		private async void Button_Clicked(object sender, EventArgs e)
		{
			//await DisplayAlert("Click", ((Button)sender).ClassId, "ok");

			await Navigation.PushModalAsync(new BaseTappa());
		}
	}
}