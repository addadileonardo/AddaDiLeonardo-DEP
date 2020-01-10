using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace AddaDiLeonardo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavPage : Xamarin.Forms.TabbedPage
    {
        public NavPage ()
        {
            InitializeComponent();
            On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            //On<iOS>().SetToolbarPlacement(ToolbarPlacement.Bottom); ????

            //Tab Pages

            Children.Add(new NavigationPage(new HomePage()) { Title = "Home", BackgroundColor = Color.Black, Icon = "home.png" });
            Children.Add(new NavigationPage(new Map()) { Title = "Mappa", BackgroundColor = Color.Black, Icon = "home.png" });
            Children.Add(new NavigationPage(new Settings()) { Title = "Impostazioni", BackgroundColor = Color.Black, Icon = "home.png" });
            //Children.Add(new NavigationPage(new MappaPage()) { Title = "Mappa", BackgroundColor = Color.LightGreen, IconImageSource = "map.png" });

            NavigationPage.SetHasNavigationBar(this, false);

        }
    }
}