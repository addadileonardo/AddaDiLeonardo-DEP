using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Google.Android.Exoplayer2;
using Com.Google.Android.Exoplayer2.Source.Smoothstreaming;
using Com.Google.Android.Exoplayer2.Trackselection;
using Com.Google.Android.Exoplayer2.UI;
using Com.Google.Android.Exoplayer2.Upstream;
using Xamarin.Forms.Platform.Android;

namespace AddaDiLeonardo.Droid
{
    [Obsolete]
    public class VideoPlayerRenderer : ViewRenderer<VideoPlayer, SimpleExoPlayerView>
    {
        public VideoPlayerRenderer(Context context) : base(context) { }

        private SimpleExoPlayerView _playerView;
        private SimpleExoPlayer _player;

        protected override void OnElementChanged(ElementChangedEventArgs<VideoPlayer> e)
        {
            base.OnElementChanged(e);

            if (_player == null)
                InitializePlayer();

            Play();
        }

        private void InitializePlayer()
        {
            _player = ExoPlayerFactory.NewSimpleInstance(Context, new DefaultTrackSelector());
            _player.PlayWhenReady = true;
            _playerView = new SimpleExoPlayerView(Context) { Player = _player };
            SetNativeControl(_playerView);
        }

        private void Play()
        {
            Uri sourceUri = Uri.Parse(Element.SourceUrl);
            DefaultHttpDataSourceFactory httpDataSourceFactory = new DefaultHttpDataSourceFactory("1");
            DefaultSsChunkSource.Factory ssChunkFactory = new DefaultSsChunkSource.Factory(httpDataSourceFactory);
            Handler emptyHandler = new Handler();

            SsMediaSource ssMediaSource = new SsMediaSource(sourceUri, httpDataSourceFactory, ssChunkFactory, emptyHandler, this);
            _player.Prepare(ssMediaSource);
        }
    }
}