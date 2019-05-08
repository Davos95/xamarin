using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiposAlerta
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaginaModal : ContentPage
	{
        public String Dato { get; set; }
		public PaginaModal ()
		{
			InitializeComponent();
            this.botonCerrar.Clicked += async (sender, args) =>
            {
                await Navigation.PopModalAsync();
                this.Dato = txtDato.Text;
            };
		}
	}
}