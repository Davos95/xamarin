using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TiposAlerta
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.botonSimple.Clicked += async (sender, args) =>
            {
                await DisplayAlert("Titulo del mensaje", "Soy un mensaje simple", "");
            };
            this.botonOkCancel.Clicked += botonokcancel_Clicked;
            this.botonOpciones.Clicked += botonOpciones_Clicked;
            this.botonModal.Clicked += async (sender, args) =>
            {
                PaginaModal pagina = new PaginaModal();
                
                await Navigation.PushModalAsync(pagina);
                this.lbRespuesta.Text = pagina.Dato;
            };
        }

        private async void botonOpciones_Clicked(object sender, EventArgs e)
        {
            String respuesta = await DisplayActionSheet("Campeon de Champion", "Cancelar", null,"Barcelona","City","Juventus");
            this.lbRespuesta.Text = respuesta;
        }

        private async void botonokcancel_Clicked(object sender, EventArgs e)
        {
            bool respuesta = await DisplayAlert("Titulo", "Hoy es lunes?", "Yes", "No");
            if(respuesta == true)
            {
                this.lbRespuesta.Text = "Hoy es LUNES!!!!";
            } else
            {
                this.lbRespuesta.Text = "No tienes ni idea...";
            }
        }
    }
}
