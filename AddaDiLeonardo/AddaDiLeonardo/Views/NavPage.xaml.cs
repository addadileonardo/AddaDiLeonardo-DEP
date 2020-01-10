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

            Children.Add(new NavigationPage(new HomePage()) { Title = "Home", BackgroundColor = Color.LightSkyBlue, Icon = "home.png" });
            Children.Add(new NavigationPage(new HomePage()) { Title = "Home", BackgroundColor = Color.LightSkyBlue, Icon = "home.png" });
            //Children.Add(new NavigationPage(new MappaPage()) { Title = "Mappa", BackgroundColor = Color.LightGreen, IconImageSource = "map.png" });
            //Children.Add(new NavigationPage(new ImpostazioniPage()) { Title = "Impostazioni", BackgroundColor = Color.LightGray, IconImageSource = "setting.png" });

            NavigationPage.SetHasNavigationBar(this, false);

        }
    }
}