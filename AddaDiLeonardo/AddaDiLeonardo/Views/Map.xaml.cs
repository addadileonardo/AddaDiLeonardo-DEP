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
	public partial class Map : ContentPage
	{
		public Map ()
		{
			InitializeComponent ();
			ImageMap.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Map.MappaRaul.png");
			ImagePonte.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Map.rectanglePosition.png"); 
			ImageCentrali.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Map.rectanglePosition.png");
			ImageFiume.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Map.rectanglePosition.png");
			ImageRocchetta.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Map.rectanglePosition.png");
			ImageTraghetto.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Map.rectanglePosition.png");
		}
	}
}