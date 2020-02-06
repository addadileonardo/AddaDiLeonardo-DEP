using AddaDiLeonardo.CustomControls;
using AddaDiLeonardo.Database.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AddaDiLeonardo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TappaRocchetta : ContentPage
    {
        public TappaRocchetta()
        {
            InitializeComponent();

            int IDTappa = 2;
            Tappa tappa;
            List<Sezione> Sezioni;
            List<Contenuto> Contenuti;

            var db = App.Database;

            tappa = db.GetTappaAsync(IDTappa).Result;
            Sezioni = db.GetSezioneAsync(IDTappa).Result;

            accordions = new List<Accordion>() { Accordion0, Accordion1, Accordion2, Accordion3, Accordion4 };
            foreach (Accordion accordion in accordions)
                accordion.AccordionOpened += accordionEvent;

            #region INTRODUZIONE

            imgTappa.Source = ImageSource.FromResource("AddaDiLeonardo.Content.Rocchetta.img_tappa.jpg");
            iconMarker.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Icons.pin.png");
            lblTitolo.Text = tappa.Titolo;
            lblSottotitolo.Text = tappa.Sottotitolo;
            lblDescrizione.Text = tappa.Descrizione;

            #endregion

            #region SECTION 1

            Accordion0.Title = Sezioni[0].Titolo;
            Contenuti = db.GetContenutoAsync(Sezioni[0].ID).Result.OrderBy(c => c.Indice).ToList();

            imgSection1.Source = ImageSource.FromResource("AddaDiLeonardo.Content.Rocchetta.Sezione_1.fiume_2.jpeg");
            //titolo: poetica del fiume, richiamo a sacro e femminile
            stackContenuto_0.Children.Add(new CustomLabelTitle { Text = Contenuti[0].Testo });
            //primo paragrafo

            //stackContenuto_0.Children.Add(new CustomLabel { Text = Contenuti[1].Testo });
            stackContenuto_0.Children.Add(FormattaContenuto(Contenuti[1].Testo));
            stackContenuto_0.Children.Add(FormattaContenuto(Contenuti[2].Testo));
            stackContenuto_0.Children.Add(FormattaContenuto(Contenuti[3].Testo));

            
            //titolo: Il fiume, dinamico e sacro
            stackContenuto_0.Children.Add(new CustomLabelTitle { Text = Contenuti[4].Testo });
            //secondo paragrafo
            stackContenuto_0.Children.Add(FormattaContenuto(Contenuti[5].Testo));
            stackContenuto_0.Children.Add(new Image { Source = ImageSource.FromResource("AddaDiLeonardo.Content.Rocchetta.Sezione_1.fiume_1.jpeg"), Aspect = Aspect.AspectFill, Margin = new Thickness(0, 10, 0, 10) });
            stackContenuto_0.Children.Add(FormattaContenuto(Contenuti[6].Testo));
            stackContenuto_0.Children.Add(FormattaContenuto(Contenuti[7].Testo));
            stackContenuto_0.Children.Add(new Image { Source = ImageSource.FromResource("AddaDiLeonardo.Content.Rocchetta.Sezione_1.fiume_4.jpeg"), Aspect = Aspect.AspectFill, Margin = new Thickness(0, 10, 0, 10) });
            stackContenuto_0.Children.Add(FormattaContenuto(Contenuti[8].Testo));
            stackContenuto_0.Children.Add(FormattaContenuto(Contenuti[9].Testo));

            #endregion

            #region SECTION 2

            Accordion1.Title = Sezioni[1].Titolo;
            Contenuti = db.GetContenutoAsync(Sezioni[1].ID).Result.OrderBy(c => c.Indice).ToList();

            imgSection2.Source = ImageSource.FromResource("AddaDiLeonardo.Content.Rocchetta.Sezione_2.Rocchetta_2.JPG");
            //titolo:La rocchetta luogo sacro e militare
            stackContenuto_1.Children.Add(new CustomLabelTitle { Text = Contenuti[0].Testo });
            stackContenuto_1.Children.Add(new CustomLabel { Text = Contenuti[1].Testo });
            stackContenuto_1.Children.Add(new CustomLabel { Text = Contenuti[2].Testo });
            stackContenuto_1.Children.Add(new CustomLabel { Text = Contenuti[3].Testo });

            //titolo: L'origine e la storia
            stackContenuto_1.Children.Add(new CustomLabelTitle { Text = Contenuti[4].Testo });
            stackContenuto_1.Children.Add(new Image { Source = ImageSource.FromResource("AddaDiLeonardo.Content.Rocchetta.Sezione_2.Rocchetta_3.jpg"), Aspect = Aspect.AspectFill, Margin = new Thickness(0, 10, 0, 10) });
            stackContenuto_1.Children.Add(new CustomLabel { Text = Contenuti[5].Testo });
            stackContenuto_1.Children.Add(new Image { Source = ImageSource.FromResource("AddaDiLeonardo.Content.Rocchetta.Sezione_2.Rocchetta_ga.jpg"), Aspect = Aspect.AspectFill, Margin = new Thickness(0, 10, 0, 10) });
            stackContenuto_1.Children.Add(new CustomLabel { Text = Contenuti[6].Testo });
            stackContenuto_1.Children.Add(new CustomLabel { Text = Contenuti[7].Testo });
            stackContenuto_1.Children.Add(new Image { Source = ImageSource.FromResource("AddaDiLeonardo.Content.Rocchetta.Sezione_2.Rocchetta_1.jpeg"), Aspect = Aspect.AspectFill, Margin = new Thickness(0, 10, 0, 10) });
            stackContenuto_1.Children.Add(new CustomLabel { Text = Contenuti[8].Testo });
            stackContenuto_1.Children.Add(new Image { Source = ImageSource.FromResource("AddaDiLeonardo.Content.Rocchetta.Sezione_2.Rocchetta_Leonardo.jpeg"), Aspect = Aspect.AspectFill, Margin = new Thickness(0, 10, 0, 10) });
            stackContenuto_1.Children.Add(new CustomLabel { Text = Contenuti[9].Testo });

            #endregion

            #region SECTION 3

            Accordion2.Title = Sezioni[2].Titolo;
            Contenuti = db.GetContenutoAsync(Sezioni[2].ID).Result.OrderBy(c => c.Indice).ToList();

            //imgSection3.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Tappa1.adda.jpg"); //NO IMMAGINE??
            stackContenuto_2.Children.Add(new CustomLabelTitle { Text = Contenuti[0].Testo });
            stackContenuto_2.Children.Add(new CustomLabel { Text = Contenuti[1].Testo });
            stackContenuto_2.Children.Add(new CustomLabel { Text = Contenuti[2].Testo });
            stackContenuto_2.Children.Add(new CustomLabel { Text = Contenuti[3].Testo });
            stackContenuto_2.Children.Add(new CustomLabel { Text = Contenuti[4].Testo });

            #endregion

            #region SECTION 4

            Accordion3.Title = Sezioni[3].Titolo;
            Contenuti = db.GetContenutoAsync(Sezioni[3].ID).Result.OrderBy(c => c.Indice).ToList();

            imgSection4.Source = ImageSource.FromResource("AddaDiLeonardo.Content.Rocchetta.Sezione_4.TreCorni_1.jpeg");
            //titolo:Racconto del dipinto
            stackContenuto_3.Children.Add(new CustomLabel { Text = Contenuti[0].Testo });
            stackContenuto_3.Children.Add(new Image { Source = ImageSource.FromResource("AddaDiLeonardo.Content.Rocchetta.Sezione_4.Vergine.jpg"), Aspect=Aspect.AspectFit, Margin = new Thickness(0,10,0,10) });
            stackContenuto_3.Children.Add(new CustomLabel { Text = Contenuti[1].Testo, FontSize=15});

            stackContenuto_3.Children.Add(new CustomLabel { Text = Contenuti[2].Testo });
            stackContenuto_3.Children.Add(new Image { Source = ImageSource.FromResource("AddaDiLeonardo.Content.Rocchetta.Sezione_4.TreCorni_3.jpg"), Aspect = Aspect.AspectFit, Margin = new Thickness(0, 10, 0, 10) });
            stackContenuto_3.Children.Add(new CustomLabelTitle { Text = Contenuti[3].Testo });
            stackContenuto_3.Children.Add(new CustomLabel { Text = Contenuti[4].Testo });
            stackContenuto_3.Children.Add(new CustomLabelTitle { Text = Contenuti[5].Testo });
            stackContenuto_3.Children.Add(new CustomLabel { Text = Contenuti[6].Testo });
            stackContenuto_3.Children.Add(new Image { Source = ImageSource.FromResource("AddaDiLeonardo.Content.Rocchetta.Sezione_4.TreCorni_2.jpg"), Aspect = Aspect.AspectFit, Margin = new Thickness(0, 10, 0, 10) });
            stackContenuto_3.Children.Add(new CustomLabelTitle { Text = Contenuti[7].Testo });
            stackContenuto_3.Children.Add(new CustomLabel { Text = Contenuti[8].Testo });
            //stackContenuto_3.Children.Add(new CustomLabel { Text = Contenuti[9].Testo }); //è sbagliato!!!!
            stackContenuto_3.Children.Add(new CustomLabel { Text = Contenuti[10].Testo , FontAttributes = FontAttributes.Italic});
            #endregion

            #region SECTION 5

            Accordion4.Title = Sezioni[4].Titolo;
            Contenuti = db.GetContenutoAsync(Sezioni[4].ID).Result.OrderBy(c => c.Indice).ToList();

            imgSection5.Source = ImageSource.FromResource("AddaDiLeonardo.Content.Rocchetta.Sezione_2.Rocchetta_2.JPG");
            stackContenuto_4.Children.Add(new CustomLabelTitle { Text = Contenuti[0].Testo });
            stackContenuto_4.Children.Add(new CustomLabel { Text = Contenuti[1].Testo });
            stackContenuto_4.Children.Add(new CustomLabel { Text = Contenuti[2].Testo });
            //stackContenuto_4.Children.Add(new Image { Source = ImageSource.FromResource("AddaDiLeonardo.Content.Rocchetta.Sezione_5.Riccioli.png"), Aspect = Aspect.AspectFit, Margin = new Thickness(0, 10, 0, 10) });
            stackContenuto_4.Children.Add(new CustomLabelTitle { Text = Contenuti[3].Testo });
            stackContenuto_4.Children.Add(new CustomLabel { Text = Contenuti[4].Testo });
            //stackContenuto_4.Children.Add(new Image { Source = ImageSource.FromResource("AddaDiLeonardo.Content.Rocchetta.Sezione_5.Grotta.png"), Aspect = Aspect.AspectFit, Margin = new Thickness(0, 10, 0, 10) });
            stackContenuto_4.Children.Add(new CustomLabel { Text = Contenuti[5].Testo });

            stackContenuto_4.Children.Add(new CustomLabelTitle { Text = Contenuti[6].Testo });
            stackContenuto_4.Children.Add(new CustomLabel { Text = Contenuti[7].Testo });

            stackContenuto_4.Children.Add(new CustomLabelTitle { Text = Contenuti[8].Testo });
            stackContenuto_4.Children.Add(new CustomLabel { Text = Contenuti[9].Testo });
            stackContenuto_4.Children.Add(new CustomLabel { Text = Contenuti[10].Testo });

            #endregion
        }

        static List<Accordion> accordions;
        private void accordionEvent(object sender, EventArgs e)
        {
            accordions.Remove((Accordion)sender);
            foreach (Accordion accordion in accordions)
                if (accordion.IsOpen)
                    accordion.IsOpen = !accordion.IsOpen;
            accordions.Add((Accordion)sender);
            Thread.Sleep((int)Accordion.AnimationDuration);
            ScrollTop(((Accordion)sender).AccordionName);
        }

        private void ScrollTop(string elementname)
        {
            this.Scroll.ScrollToAsync(this.FindByName<Element>(elementname), ScrollToPosition.Start, true);
        }

        private CustomLabel FormattaContenuto(string contenuto)
        {
            CustomLabel label = new CustomLabel();
            FormattedString formatted = new FormattedString();
            if (contenuto.Contains("**"))
            {
                string[] splits = contenuto.Split('*');
                for (int x = 0; x < splits.Length; x++)
                {
                    Span span = new Span() { Text = splits[x], 
                        FontFamily = Device.RuntimePlatform == Device.iOS ? "Roboto-Light" : Device.RuntimePlatform == Device.Android ? "Roboto-Light.ttf#Roboto" : "Assets/Roboto-Light.ttf#Roboto",
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
                    if (x == 0 || x == splits.Length - 1)
                    {
                        formatted.Spans.Add(span);
                        continue;
                    }

                    if (splits[x - 1] == "" && splits[x + 1] == "")
                    {
                        span.FontAttributes = FontAttributes.Bold;
                        span.FontFamily = Device.RuntimePlatform == Device.iOS ? "Roboto-Regular" : Device.RuntimePlatform == Device.Android ? "Roboto-Regular.ttf#Roboto" : "Assets/Roboto-Regular.ttf#Roboto";
                        //span.ForegroundColor = Color.Black;
                    }
                    formatted.Spans.Add(span);
                }
                label.FormattedText = formatted;
            }
            else
                label.Text = contenuto;

            return label;
        }

        private object syncLockPlayer = new object();
        bool isInCallPlayer = false;

        private async void imgTappa_Clicked(object sender, EventArgs e)
        {
            lock (syncLockPlayer)
            {
                if (isInCallPlayer)
                    return;
                isInCallPlayer = true;
            }

            try
            {
                await Navigation.PushModalAsync(new PlayerPage("https://drive.google.com/uc?export=download&id=1-ybKXJo6ZUxK-OAVCftXiX0gq7IOpbQB"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                lock (syncLockPlayer)
                {
                    isInCallPlayer = false;
                }
            }
        }

        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    Navigation.PopModalAsync();
        //}
    }
}