﻿using AddaDiLeonardo.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AddaDiLeonardo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavPage();
        }

        public static int ScreenHeight { get; set; }
        public static int ScreenWidth { get; set; }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
