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
                        var TappaRocchetta = new TappaRocchetta();
                        await Navigation.PushModalAsync(TappaRocchetta);
                        break;

                    case "step4":
                        var TappaCentrali = new TappaCentrali();
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
                await Navigation.PushModalAsync(new PlayerPage("https://drive.google.com/uc?export=download&id=1-ybKXJo6ZUxK-OAVCftXiX0gq7IOpbQB"));
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