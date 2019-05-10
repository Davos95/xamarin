using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinRealm.Models;
using XamarinRealm.Services;
using XamarinRealm.ViewModels;

namespace XamarinRealm.Views.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Productos1 : ContentPage
	{

		public Productos1 ()
		{
			InitializeComponent ();
            this.botonproductos.Clicked += GuardarProductos;
		}

        private void GuardarProductos(object sender, EventArgs e)
        {
            Random random = new Random();
            int num = random.Next(1, 200);
            String nombreproducto = "Producto: " + num;
            //ESTO SOLO UNA INSTANCIA
            //SessionService session = new SessionService();
            //DEBEMOS UTILIZAR AUTOFAC(Locator) PARA RESOLVER LAS CLASES
            
            //El CONTAINER ESTA REALIZANDO EL new POR NOSOTROS

            SessionService session = App.Locator.SessionService;
            Producto producto = new Producto();
            producto.Nombre = nombreproducto;
            producto.Precio = random.Next(1, 900);
            session.Productos.Add(producto);
            session.Datos.Add(nombreproducto);
            this.lblProductos.Text = "Productos: " + session.Productos.Count();

            //DEVOLVEMOS UNA RESPUESTA A UPDATE EN EL CENTRO DE MENSAJES
            //INDICAMOS LA CLASE QUE DESEAMOS QUE REALICE LA ACCION DEL SUBSCRIBE
            MessagingCenter.Send(new ProductosViewModel(), "UPDATE");

        }
    }
}