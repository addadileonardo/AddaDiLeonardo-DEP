using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AddaDiLeonardo
{
    public class LabelUtilities
    {
        public static CustomLabel FormattaContenuto(string contenuto)
        {
            CustomLabel label = new CustomLabel();
            FormattedString formatted = new FormattedString();
            if (contenuto.Contains("**"))
            {
                string[] splits = contenuto.Split('*');
                int x = 0;
                while (x < splits.Length)
                {
                    Span span = new Span()
                    {
                        Text = splits[x],
                        FontFamily = Device.RuntimePlatform == Device.iOS ? "Roboto-Light" : Device.RuntimePlatform == Device.Android ? "Roboto-Light.ttf#Roboto" : "Assets/Roboto-Light.ttf#Roboto",
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
                    };
                    if (x == 0 || x == splits.Length - 1)
                    {
                        formatted.Spans.Add(span);
                        x++;
                        continue;
                    }

                    if (splits[x - 1] == "" && splits[x + 1] == "")
                    {
                        span.FontAttributes = FontAttributes.Bold;
                        span.FontFamily = Device.RuntimePlatform == Device.iOS ? "Roboto-Regular" : Device.RuntimePlatform == Device.Android ? "Roboto-Regular.ttf#Roboto" : "Assets/Roboto-Regular.ttf#Roboto";
                        //span.ForegroundColor = Color.Black;

                        splits = splits.RemoveAt(x - 1);
                        x--;
                        splits = splits.RemoveAt(x + 1);
                    }
                    formatted.Spans.Add(span);
                    x++;
                }
                label.FormattedText = formatted;
            }
            else
                label.Text = contenuto;

            return label;
        }
    }
}
