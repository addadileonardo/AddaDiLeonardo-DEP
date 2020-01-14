using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AddaDiLeonardo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BaseTappa : ContentPage
    {
        public BaseTappa()
        {
            InitializeComponent();
            imgTappa.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Tappa_ponte.jpg");
            imgFirstSection0.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Tappa1.adda.jpg");
            indicator0.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Icons.arrow.png");
            indicator1.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Icons.arrow.png");
            indicator2.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Icons.arrow.png");
            indicator3.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Icons.arrow.png");
            indicator4.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Icons.arrow.png");




            wbTappa.Source = new HtmlWebViewSource()
            {
                Html = @"<html><body>
                            <h1>CAZZO</h1>
                        </body></html>"
            };




        }
    }
}