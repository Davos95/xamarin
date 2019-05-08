using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiposLayout.XamlViews;
using Xamarin.Forms;

namespace TiposLayout
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.botonStack.Clicked += async (sender, args) => await Navigation.PushAsync(new CodeViews.StackLayoutView());
            this.botonFrame.Clicked += async (sender, args) => await Navigation.PushAsync(new CodeViews.FrameView());
            this.botonScroll.Clicked += async (sender, args) => await Navigation.PushAsync(new CodeViews.ScrollViewPage());
            this.botonFlex.Clicked += async (sender, args) => await Navigation.PushAsync(new CodeViews.FlexLayoutPage());
            this.botonAbsolute.Clicked += async (sender, args) => await Navigation.PushAsync(new AbsoluteLayoutView());
            this.botonPrac1.Clicked += async (sender, args) => await Navigation.PushAsync(new Practicas.Practica1Collatz());
            this.botonPrac2.Clicked += async (sender, args) => await Navigation.PushAsync(new Practicas.Practica2CollatzCombinado());

        }
    }
}
