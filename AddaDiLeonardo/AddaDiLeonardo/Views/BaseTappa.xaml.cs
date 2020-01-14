using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Reflection;

namespace AddaDiLeonardo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BaseTappa : ContentPage
    {
        public BaseTappa()
        {
            InitializeComponent();
            imgTappa.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Ponte.jpg");
            imgFirstSection0.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Tappa1.adda.jpg");
            //indicator0.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Icons.arrow.png");
            //indicator1.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Icons.arrow.png");
            //indicator2.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Icons.arrow.png");
            //indicator3.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Icons.arrow.png");
            //indicator4.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Icons.arrow.png");

            string html = default(string);
            string htmlFileName = "BaseHtml.html";
            var assembly = typeof(BaseTappa).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.Files.BaseTappa.{htmlFileName}");
            using (var reader = new StreamReader(stream))
            {
               html = reader.ReadToEnd();
            }



            wbTappa.Source = new HtmlWebViewSource()
            {
                Html = html
            };




        }
    }
}