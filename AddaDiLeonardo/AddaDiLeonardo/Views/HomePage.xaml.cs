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
            ImgWall.Source = ImageSource.FromResource("AddaDiLeonardo.Images.backgroundFadeBlack.png");
        }

		private async void Button_Clicked(object sender, EventArgs e)
		{
			//await DisplayAlert("Click", ((Button)sender).ClassId, "ok");

			await Navigation.PushModalAsync(new TappaPage(((Button)sender).ClassId));
		}
	}
}