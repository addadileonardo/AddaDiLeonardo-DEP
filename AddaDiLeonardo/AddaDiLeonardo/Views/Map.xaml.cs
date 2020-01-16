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

        private object syncLockTappa = new object();
        bool isInCallTappa = false;

        private async void OnImageNameTapped(object sender, EventArgs args)
        {
            lock (syncLockTappa)
            {
                if (isInCallTappa)
                    return;
                isInCallTappa = true;
            }

            try
            {
                
                switch (((Image)sender).ClassId) {

                    case "traghetto":
                        var TappaTraghetto = new TappaPonte();
                        await Navigation.PushModalAsync(TappaTraghetto);
                        break;

                    case "ponte":
                        var TappaPonte = new TappaPonte();
                        await Navigation.PushModalAsync(TappaPonte);
                        break;

                    case "rocchetta":
                        var TappaRocchetta = new TappaPonte();
                        await Navigation.PushModalAsync(TappaRocchetta);
                        break;

                    case "fiume":
                        var TappaFiume = new TappaPonte();
                        await Navigation.PushModalAsync(TappaFiume);
                        break;

                    case "centrali":
                        var TappaCentrali = new TappaPonte();
                        await Navigation.PushModalAsync(TappaCentrali);
                        break;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                lock (syncLockTappa)
                {
                    isInCallTappa = false;
                }
            }

        }

    }
}