using LibVLCSharp.Shared;
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
    public partial class PlayerPage : ContentPage
    {
        public PlayerPage(string link)
        {
            InitializeComponent();
            Core.Initialize();
            var _libVLC = new LibVLC();

            //var id = match();

            var media = new Media(_libVLC, link, FromType.FromLocation);
            //media.Parse(MediaParseOptions.ParseNetwork);
            myvideo.MediaPlayer = new MediaPlayer(media);
            myvideo.MediaPlayer.Fullscreen = true;
            myvideo.MediaPlayer.Play();

            
        }

        
    }
}