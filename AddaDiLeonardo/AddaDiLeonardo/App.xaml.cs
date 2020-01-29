using AddaDiLeonardo.Database;
using AddaDiLeonardo.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AddaDiLeonardo
{
    public partial class App : Application
    {
        private const string LanguageKey = "Lingua";

        private static readonly string[] DBNames = new string[3] { "Italian.db3", "English.db3", "French.db3" };

        public App()
        {
            InitializeComponent();

            MainPage = new NavPage();
        }

        public static int ScreenHeight { get; set; }
        public static int ScreenWidth { get; set; }

        private static LanguageDatabase database;
        public static LanguageDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new LanguageDatabase(DBNames[0]);
                }
                return database;
            }
        }

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

        public int Lingua
        {
            get
            {
                if (Properties.ContainsKey(LanguageKey))
                    return (int)Properties[LanguageKey];

                return 0;
            }
            set
            {
                Properties[LanguageKey] = value;
            }
        }
    }
}
