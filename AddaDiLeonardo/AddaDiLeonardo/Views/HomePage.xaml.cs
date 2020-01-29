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
        public HomePage()
        {
            InitializeComponent();

            //To update: source of image (incorporate and XAML)
            //background.Source = ImageSource.FromResource("AddaDiLeonardo.Images.backgroundFadeBlack.png");
            //step1.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Fiume.jpg");
            //step2.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Tappa_ponte.jpg");
            //step3.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Centrale.jpg");
            //step4.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Vergine.jpg");

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

                switch (((Image)sender).ClassId)
                {

                    case "step1":
                        var TappaTraghetto = new TappaTraghetto();
                        await Navigation.PushModalAsync(TappaTraghetto);
                        break;

                    case "step2":
                        var TappaPonte = new TappaPonte();
                        await Navigation.PushModalAsync(TappaPonte);
                        break;

                    case "step3":
                        var Tappa3 = new TappaPonte();
                        await Navigation.PushModalAsync(Tappa3);
                        break;

                    case "step4":
                        var Tappa4 = new TappaPonte();
                        await Navigation.PushModalAsync(Tappa4);
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

        private object syncLockPlayer = new object();
        bool isInCallPlayer = false;

        private async void btnRiproduci_Clicked(object sender, EventArgs e)
        {
            lock (syncLockPlayer)
            {
                if (isInCallPlayer)
                    return;
                isInCallPlayer = true;
            }

            try
            {
                await Navigation.PushModalAsync(new PlayerPage("https://drive.google.com/uc?export=download&id=1PJ5AqNfCRwfOWWrZ-l9Gp6GOSILWVhDV"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                lock (syncLockPlayer)
                {
                    isInCallPlayer = false;
                }
            }

        }
    }
}