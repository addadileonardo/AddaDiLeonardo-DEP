﻿using System;
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

            //To update: source of image (incorporate and XAML)
            background.Source = ImageSource.FromResource("AddaDiLeonardo.Images.backgroundFadeBlack.png");
            step1.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Fiume.jpg");
            step2.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Tappa_ponte.jpg");
            step3.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Centrale.jpg");
            step4.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Vergine.jpg");

        }

        private async void OnImageNameTapped(object sender, EventArgs args)
        {
            try
            {
                await Navigation.PushModalAsync(new TappaPage());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

	}
}