using PaginasBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PaginasBinding
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BindingClases : ContentPage
	{
        public Jugador MiJugador { get; set; }
		public BindingClases ()
		{
			InitializeComponent ();
            this.MiJugador = new Jugador();
            this.MiJugador.Nombre = "Isco Alarcon";
            this.MiJugador.Equipo = "Real Madrid";
            this.MiJugador.Imagen = "https://cdn.20m.es/img2/recortes/2018/04/15/679883-600-338.jpg?v=20181016121740";
            this.MiJugador.Descripcion = "Es un vago, pero juega bien...";
            this.BindingContext = this.MiJugador;
		}
	}
}