using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinRealm.Services;

namespace XamarinRealm.Views.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PrincipalProductos : ContentPage
	{
		public PrincipalProductos ()
		{
			InitializeComponent ();
            this.botonproductos1.Clicked += Botonproductos1_Clicked;
            this.botonproductos2.Clicked += Botonproductos2_Clicked;
            this.botonnumeroproductos.Clicked += Botonnumeroproductos_Clicked;
            this.botonmostrar.Clicked += Botonmostrar_Clicked;
		}

        private async void Botonmostrar_Clicked(object sender, EventArgs e)
        {
            ListadoProductos view = new ListadoProductos();
            await Navigation.PushAsync(view);
        }

        private void Botonnumeroproductos_Clicked(object sender, EventArgs e)
        {
            //NECESITAMOS LA SESSION
            SessionService session = App.Locator.SessionService;
            this.lblproductos.Text = "Numero productos:" + session.Productos.Count;


        }

        private async void Botonproductos2_Clicked(object sender, EventArgs e)
        {
            Productos2 view = new Productos2();
            await Navigation.PushModalAsync(view);
        }

        private async void Botonproductos1_Clicked(object sender, EventArgs e)
        {
            Productos1 view = new Productos1();
            await Navigation.PushModalAsync(view);
        }


    }
}