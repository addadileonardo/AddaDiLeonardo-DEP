using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AddaDiLeonardo
{
    public class VideoPlayer : View
    {
        public static readonly BindableProperty SourceUrlProperty =
            BindableProperty.Create("SourceUrl", typeof(string), typeof(VideoPlayer));

        public string SourceUrl
        {
            get => (string)GetValue(SourceUrlProperty);
            set => SetValue(SourceUrlProperty, value);
        }
    }
}
