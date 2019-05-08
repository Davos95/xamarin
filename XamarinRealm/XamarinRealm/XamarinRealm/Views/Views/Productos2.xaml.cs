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
	public partial class Productos2 : ContentPage
	{
		public Productos2 ()
		{
			InitializeComponent ();
            this.botonproductos.Clicked += GuardarProductos;
		}

        private void GuardarProductos(object sender, EventArgs e)
        {
            Random random = new Random();
            int num = random.Next(1, 200);
            String producto = "Producto: " + num;
            //ESTO SOLO UNA INSTANCIA
            //SessionService session = new SessionService();
            //DEBEMOS UTILIZAR AUTOFAC(Locator) PARA RESOLVER LAS CLASES

            //El CONTAINER ESTA REALIZANDO EL new POR NOSOTROS

            SessionService session = App.Locator.SessionService;
            session.Datos.Add(producto);
            this.lblProductos.Text = "Productos: " + session.Datos.Count();
        }
    }
}