﻿using AddaDiLeonardo.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AddaDiLeonardo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TappaPonte : ContentPage
    {
        public TappaPonte()
        {
            InitializeComponent();
            
            imgTappa.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Ponte.Ponte.jpg");
            imgSection1.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Tappa1.adda.jpg");
            imgSection2.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Tappa1.adda.jpg");
            imgSection3.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Tappa1.adda.jpg");
            imgSection4.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Tappa1.adda.jpg");
            imgSection5.Source = ImageSource.FromResource("AddaDiLeonardo.Images.Tappa1.adda.jpg");

            webIntro.Source = new HtmlWebViewSource()
            {
                BaseUrl = DependencyService.Get<IBaseUrl>().Get(),
                Html = "<html><head></head><body>    <style>        @font-face {            font-family: Oswald;            src: url('Oswald-Light.ttf');        }        @font-face {            font-family: Roboto-Light;            src: url('Roboto-Light.ttf');        }        .fas {            color: #DD5246;        }    </style>    <div style=\"margin-left:5px; margin-right:5px; margin-bottom:5px;\">        <h1 style=\"font-family: Oswald, sans-serif; margin-top:15px;\"><b>Ponte San Michele</b></h1>        <p style=\"font-family: Roboto-Light, sans-serif; text-align:right;\">Paderno d'Adda <i><img src=\"Icons/marker.png\" style=\"width:13px;\" /></i></p>        <p style=\"font-family: Roboto-Light, sans-serif; text-align:justify; font-style:italic;\">Una delle più interessanti realizzazioni dell'ingegneria italiana nell'800, punto di unione tra le due sponde rivali dell'Adda.</p>        <p style=\"font-family: Roboto-Light, sans-serif; text-align:justify; margin-bottom:15px;\">Il Ponte San Michele, situato a Paderno d'Adda, è stato progettato dall'ingegnere svizzero Jules Röthlisberger nel 1889, come collegamento viabilistico e ferroviario tra l'area economica della bergamasca e quella milanese. La struttura e i numerosi eventi di cui è stato teatro l'hanno reso un'opera architettonica di grande importanza storica.</p>    </div></body></html>"
            };
            webSection1.Source = new HtmlWebViewSource()
            {
                BaseUrl = DependencyService.Get<IBaseUrl>().Get(),
                Html = "<html><head></head><body>    <style>        @font-face {            font-family: Oswald;            src: url('Oswald-Light.ttf');        }        @font-face {            font-family: Roboto-Light;            src: url('Roboto-Light.ttf');        }        .fas {            color: #DD5246;        }    </style>    <div>        <p style=\"font-family: Roboto-Light, sans-serif; text-align:justify; margin-left:5px; margin-right:5px;\">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque porta sit amet libero molestie placerat. Vivamus facilisis suscipit justo id posuere. Donec fringilla ligula at urna vestibulum elementum. Proin eget quam finibus, facilisis elit vitae, commodo lorem. Quisque a iaculis lectus, quis malesuada augue. Nulla interdum facilisis malesuada. Mauris pulvinar mi sed facilisis vehicula. Mauris et blandit dolor.</p>        <img src=\"Ponte/Ponte.jpg\" style=\"width:100%;\" />        <p style=\"font-family: Roboto-Light, sans-serif; text-align:justify; margin-left:5px; margin-right:5px;\">Nunc condimentum dolor vel congue suscipit. Vestibulum sit amet sodales massa. Nam vitae libero ullamcorper, mattis justo a, viverra sapien. Aliquam finibus tincidunt auctor. Etiam vitae porttitor magna. In scelerisque quis eros eu pretium. Etiam eget enim sed massa elementum condimentum eu a magna. Quisque interdum volutpat interdum. Sed consectetur vel nibh a rutrum. Donec massa nisl, lacinia a purus et, tempor lacinia lorem. Aliquam ullamcorper rutrum euismod. Nam faucibus neque orci, sed pulvinar lorem semper a. Nullam in pretium mi, vitae ornare urna.</p>        <img src=\"Ponte/Ponte.jpg\" style=\"width:100%;\" />        <p style=\"font-family: Roboto-Light, sans-serif; text-align:justify; margin-left:5px; margin-right:5px;\">In est metus, tempor in ultricies quis, eleifend vel lacus. Nulla vel nulla vel urna tincidunt varius id id lacus. Nam velit risus, sollicitudin eu commodo quis, consequat sed quam. Mauris ac lacus quis risus aliquet venenatis. Donec ullamcorper facilisis fringilla. Cras vitae risus dolor. Etiam a interdum mauris. Sed tincidunt eleifend erat non tincidunt. Phasellus consectetur nisl ut elit lobortis malesuada a sit amet nisi.</p>            </div></body></html>"
            };
            webSection2.Source = new HtmlWebViewSource()
            {
                BaseUrl = DependencyService.Get<IBaseUrl>().Get(),
                Html = "<html><head></head><body>    <style>        @font-face {            font-family: Oswald;            src: url('Oswald-Light.ttf');        }        @font-face {            font-family: Roboto-Light;            src: url('Roboto-Light.ttf');        }        .fas {            color: #DD5246;        }    </style>    <div>        <p style=\"font-family: Roboto-Light, sans-serif; text-align:justify; margin-left:5px; margin-right:5px;\">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque porta sit amet libero molestie placerat. Vivamus facilisis suscipit justo id posuere. Donec fringilla ligula at urna vestibulum elementum. Proin eget quam finibus, facilisis elit vitae, commodo lorem. Quisque a iaculis lectus, quis malesuada augue. Nulla interdum facilisis malesuada. Mauris pulvinar mi sed facilisis vehicula. Mauris et blandit dolor.</p>        <img src=\"Ponte/Ponte.jpg\" style=\"width:100%;\" />        <p style=\"font-family: Roboto-Light, sans-serif; text-align:justify; margin-left:5px; margin-right:5px;\">Nunc condimentum dolor vel congue suscipit. Vestibulum sit amet sodales massa. Nam vitae libero ullamcorper, mattis justo a, viverra sapien. Aliquam finibus tincidunt auctor. Etiam vitae porttitor magna. In scelerisque quis eros eu pretium. Etiam eget enim sed massa elementum condimentum eu a magna. Quisque interdum volutpat interdum. Sed consectetur vel nibh a rutrum. Donec massa nisl, lacinia a purus et, tempor lacinia lorem. Aliquam ullamcorper rutrum euismod. Nam faucibus neque orci, sed pulvinar lorem semper a. Nullam in pretium mi, vitae ornare urna.</p>        <img src=\"Ponte/Ponte.jpg\" style=\"width:100%;\" />        <p style=\"font-family: Roboto-Light, sans-serif; text-align:justify; margin-left:5px; margin-right:5px;\">In est metus, tempor in ultricies quis, eleifend vel lacus. Nulla vel nulla vel urna tincidunt varius id id lacus. Nam velit risus, sollicitudin eu commodo quis, consequat sed quam. Mauris ac lacus quis risus aliquet venenatis. Donec ullamcorper facilisis fringilla. Cras vitae risus dolor. Etiam a interdum mauris. Sed tincidunt eleifend erat non tincidunt. Phasellus consectetur nisl ut elit lobortis malesuada a sit amet nisi.</p>            </div></body></html>"
            };
            webSection3.Source = new HtmlWebViewSource()
            {
                BaseUrl = DependencyService.Get<IBaseUrl>().Get(),
                Html = "<html><head></head><body>    <style>        @font-face {            font-family: Oswald;            src: url('Oswald-Light.ttf');        }        @font-face {            font-family: Roboto-Light;            src: url('Roboto-Light.ttf');        }        .fas {            color: #DD5246;        }    </style>    <div>        <p style=\"font-family: Roboto-Light, sans-serif; text-align:justify; margin-left:5px; margin-right:5px;\">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque porta sit amet libero molestie placerat. Vivamus facilisis suscipit justo id posuere. Donec fringilla ligula at urna vestibulum elementum. Proin eget quam finibus, facilisis elit vitae, commodo lorem. Quisque a iaculis lectus, quis malesuada augue. Nulla interdum facilisis malesuada. Mauris pulvinar mi sed facilisis vehicula. Mauris et blandit dolor.</p>        <img src=\"Ponte/Ponte.jpg\" style=\"width:100%;\" />        <p style=\"font-family: Roboto-Light, sans-serif; text-align:justify; margin-left:5px; margin-right:5px;\">Nunc condimentum dolor vel congue suscipit. Vestibulum sit amet sodales massa. Nam vitae libero ullamcorper, mattis justo a, viverra sapien. Aliquam finibus tincidunt auctor. Etiam vitae porttitor magna. In scelerisque quis eros eu pretium. Etiam eget enim sed massa elementum condimentum eu a magna. Quisque interdum volutpat interdum. Sed consectetur vel nibh a rutrum. Donec massa nisl, lacinia a purus et, tempor lacinia lorem. Aliquam ullamcorper rutrum euismod. Nam faucibus neque orci, sed pulvinar lorem semper a. Nullam in pretium mi, vitae ornare urna.</p>        <img src=\"Ponte/Ponte.jpg\" style=\"width:100%;\" />        <p style=\"font-family: Roboto-Light, sans-serif; text-align:justify; margin-left:5px; margin-right:5px;\">In est metus, tempor in ultricies quis, eleifend vel lacus. Nulla vel nulla vel urna tincidunt varius id id lacus. Nam velit risus, sollicitudin eu commodo quis, consequat sed quam. Mauris ac lacus quis risus aliquet venenatis. Donec ullamcorper facilisis fringilla. Cras vitae risus dolor. Etiam a interdum mauris. Sed tincidunt eleifend erat non tincidunt. Phasellus consectetur nisl ut elit lobortis malesuada a sit amet nisi.</p>            </div></body></html>"
            };
            webSection4.Source = new HtmlWebViewSource()
            {
                BaseUrl = DependencyService.Get<IBaseUrl>().Get(),
                Html = "<html><head></head><body>    <style>        @font-face {            font-family: Oswald;            src: url('Oswald-Light.ttf');        }        @font-face {            font-family: Roboto-Light;            src: url('Roboto-Light.ttf');        }        .fas {            color: #DD5246;        }    </style>    <div>        <p style=\"font-family: Roboto-Light, sans-serif; text-align:justify; margin-left:5px; margin-right:5px;\">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque porta sit amet libero molestie placerat. Vivamus facilisis suscipit justo id posuere. Donec fringilla ligula at urna vestibulum elementum. Proin eget quam finibus, facilisis elit vitae, commodo lorem. Quisque a iaculis lectus, quis malesuada augue. Nulla interdum facilisis malesuada. Mauris pulvinar mi sed facilisis vehicula. Mauris et blandit dolor.</p>        <img src=\"Ponte/Ponte.jpg\" style=\"width:100%;\" />        <p style=\"font-family: Roboto-Light, sans-serif; text-align:justify; margin-left:5px; margin-right:5px;\">Nunc condimentum dolor vel congue suscipit. Vestibulum sit amet sodales massa. Nam vitae libero ullamcorper, mattis justo a, viverra sapien. Aliquam finibus tincidunt auctor. Etiam vitae porttitor magna. In scelerisque quis eros eu pretium. Etiam eget enim sed massa elementum condimentum eu a magna. Quisque interdum volutpat interdum. Sed consectetur vel nibh a rutrum. Donec massa nisl, lacinia a purus et, tempor lacinia lorem. Aliquam ullamcorper rutrum euismod. Nam faucibus neque orci, sed pulvinar lorem semper a. Nullam in pretium mi, vitae ornare urna.</p>        <img src=\"Ponte/Ponte.jpg\" style=\"width:100%;\" />        <p style=\"font-family: Roboto-Light, sans-serif; text-align:justify; margin-left:5px; margin-right:5px;\">In est metus, tempor in ultricies quis, eleifend vel lacus. Nulla vel nulla vel urna tincidunt varius id id lacus. Nam velit risus, sollicitudin eu commodo quis, consequat sed quam. Mauris ac lacus quis risus aliquet venenatis. Donec ullamcorper facilisis fringilla. Cras vitae risus dolor. Etiam a interdum mauris. Sed tincidunt eleifend erat non tincidunt. Phasellus consectetur nisl ut elit lobortis malesuada a sit amet nisi.</p>            </div></body></html>"
            };
            webSection5.Source = new HtmlWebViewSource()
            {
                BaseUrl = DependencyService.Get<IBaseUrl>().Get(),
                Html = "<html><head></head><body>    <style>        @font-face {            font-family: Oswald;            src: url('Oswald-Light.ttf');        }        @font-face {            font-family: Roboto-Light;            src: url('Roboto-Light.ttf');        }        .fas {            color: #DD5246;        }    </style>    <div>        <p style=\"font-family: Roboto-Light, sans-serif; text-align:justify; margin-left:5px; margin-right:5px;\">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque porta sit amet libero molestie placerat. Vivamus facilisis suscipit justo id posuere. Donec fringilla ligula at urna vestibulum elementum. Proin eget quam finibus, facilisis elit vitae, commodo lorem. Quisque a iaculis lectus, quis malesuada augue. Nulla interdum facilisis malesuada. Mauris pulvinar mi sed facilisis vehicula. Mauris et blandit dolor.</p>        <img src=\"Ponte/Ponte.jpg\" style=\"width:100%;\" />        <p style=\"font-family: Roboto-Light, sans-serif; text-align:justify; margin-left:5px; margin-right:5px;\">Nunc condimentum dolor vel congue suscipit. Vestibulum sit amet sodales massa. Nam vitae libero ullamcorper, mattis justo a, viverra sapien. Aliquam finibus tincidunt auctor. Etiam vitae porttitor magna. In scelerisque quis eros eu pretium. Etiam eget enim sed massa elementum condimentum eu a magna. Quisque interdum volutpat interdum. Sed consectetur vel nibh a rutrum. Donec massa nisl, lacinia a purus et, tempor lacinia lorem. Aliquam ullamcorper rutrum euismod. Nam faucibus neque orci, sed pulvinar lorem semper a. Nullam in pretium mi, vitae ornare urna.</p>        <img src=\"Ponte/Ponte.jpg\" style=\"width:100%;\" />        <p style=\"font-family: Roboto-Light, sans-serif; text-align:justify; margin-left:5px; margin-right:5px;\">In est metus, tempor in ultricies quis, eleifend vel lacus. Nulla vel nulla vel urna tincidunt varius id id lacus. Nam velit risus, sollicitudin eu commodo quis, consequat sed quam. Mauris ac lacus quis risus aliquet venenatis. Donec ullamcorper facilisis fringilla. Cras vitae risus dolor. Etiam a interdum mauris. Sed tincidunt eleifend erat non tincidunt. Phasellus consectetur nisl ut elit lobortis malesuada a sit amet nisi.</p>            </div></body></html>"
            };


        }
    }
}