﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AddaDiLeonardo;
using AddaDiLeonardo.Droid;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRenderer(typeof(CustomLabel),typeof(CustomLabelRender))]
namespace AddaDiLeonardo.Droid
{
    public class CustomLabelRender:LabelRenderer
    {
        public CustomLabelRender(Context context):base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                //Control.JustificationMode = Android.Text.JustificationMode.InterWord;
            }
        }
    }
}