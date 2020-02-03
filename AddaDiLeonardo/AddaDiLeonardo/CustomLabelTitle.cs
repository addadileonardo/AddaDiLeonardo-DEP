using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AddaDiLeonardo
{
    public class CustomLabelTitle:Label
    {
        public CustomLabelTitle()
        {
            FontFamily = Device.RuntimePlatform == Device.iOS ? "Roboto-SemiBold" : Device.RuntimePlatform == Device.Android ? "Roboto-Regular.ttf#Roboto" : "Assets/Roboto-Regular.ttf#Roboto";
            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label));
            LineHeight = 1.10;
            FontAttributes = FontAttributes.Bold;
            TextColor = Color.Black;
            Margin = new Thickness(0, 10, 0, 0);
        }
    }
}
