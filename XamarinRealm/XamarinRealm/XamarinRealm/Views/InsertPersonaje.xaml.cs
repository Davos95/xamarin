using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinRealm.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InsertPersonaje : ContentPage
	{
		public InsertPersonaje ()
		{
			InitializeComponent ();
            this.botonInsertar.Clicked += BotonInsertar_Clicked;
		}

        private async void BotonInsertar_Clicked(object sender, EventArgs e)
        {

            await Navigation.PopAsync();
        }
    }
}