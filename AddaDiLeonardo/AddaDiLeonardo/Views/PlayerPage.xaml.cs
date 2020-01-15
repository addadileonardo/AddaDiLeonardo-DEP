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

            WebViewer.Source = new HtmlWebViewSource()
            {
                Html = $"<html><div  style=\"background-color:lightblue; height='300px'; width='{App.ScreenWidth - 10}px';\"> a </div></html>"
            };

        }
    }
}