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
        public PlayerPage()
        {
            InitializeComponent();

            WebViewer.HeightRequest = App.ScreenHeight;
            WebViewer.WidthRequest = App.ScreenWidth;

            WebViewer.Source = new HtmlWebViewSource()
            {
                Html = $"<html style=\"background-color:black;\"><iframe width=\"{App.ScreenWidth}\" height=\"{App.ScreenHeight - 7}\" src = \"https://www.youtube.com/embed/J3pF2jkQ4vc?fs=0&rel=0\" frameBorder=\"0\"></ iframe ></html>"
            };

        }
    }
}