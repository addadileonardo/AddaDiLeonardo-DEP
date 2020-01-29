using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AddaDiLeonardo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlayerPage : ContentPage
    {
        private string _link = default(string);
        public PlayerPage(string link)
        {
            InitializeComponent();
            Core.Initialize();
            _link = link;
        }

        private void ContentPage_Disappearing(object sender, EventArgs e)
        {
                myvideo.MediaPlayer.Stop();
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                DisplayAlert("ATTENZIONE!", "Accendi la connessione ad internet per vedere il video!", "OK");
                //LA PAGINA DEVE ESSERE CHIUSA!!
            }
            else
            {
                var _libVLC = new LibVLC();
                var media = new Media(_libVLC, _link, FromType.FromLocation);
                myvideo.MediaPlayer = new MediaPlayer(media);
                myvideo.MediaPlayer.Fullscreen = true;
                myvideo.MediaPlayer.Play();               
            }
        }
    }
}