using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using AddaDiLeonardo.Droid;
using AddaDiLeonardo.Services;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using static AddaDiLeonardo.Views.TappaPonte;
//creata da Andrea T. per incorporare le risorse locali presenti in android.assets nei file html tramite il baseUrl
[assembly: Xamarin.Forms.Dependency(typeof(BaseUrl_Android))]
namespace AddaDiLeonardo.Droid
{
    public class BaseUrl_Android : IBaseUrl
    {
        public string Get()
        {
            return "file:///android_asset/";
        }
    }
}