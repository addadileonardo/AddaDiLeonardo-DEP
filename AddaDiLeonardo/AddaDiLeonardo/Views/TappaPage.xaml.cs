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
    public partial class TappaPage : ContentPage
    {
        public TappaPage(string index)
        {
            InitializeComponent();

            switch (index)
            {
                case "btn1": BackgroundColor = Color.Red; break;
                case "btn2": BackgroundColor = Color.OrangeRed; break;
                case "btn3": BackgroundColor = Color.Green; break;
                case "btn4": BackgroundColor = Color.Yellow; break;
            }
        }
    }
}