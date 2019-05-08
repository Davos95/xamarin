using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinRealm.Models;
using XamarinRealm.Repository;
using XamarinRealm.ViewModels;
using XamarinRealm.Views;

namespace XamarinRealm
{
    public partial class MainPage : ContentPage
    {
        RepositoryRealm repo;
        public MainPage()
        {
            InitializeComponent();
            this.repo = new RepositoryRealm();
            this.botonMostrar.Clicked += botonMostrar_Clicked;
            this.botonInsertar.Clicked += botonInsertar_Clicked;
            this.botonEliminar.Clicked += botonEliminar_Clicked;
            this.botonModificar.Clicked += botonModificar_Clicked;
        }

        private async void botonModificar_Clicked(object sender, EventArgs e)
        {
            ModificarPersonaje view = new ModificarPersonaje();
            PersonajeModel viewmodel = new PersonajeModel();
            int num = int.Parse(this.cajanumero.Text);
            Personaje personaje = this.repo.BuscarPersonaje(num);
            viewmodel.Personaje = personaje;
            view.BindingContext = viewmodel;
            await Navigation.PushModalAsync(view);
        }

        private async void botonEliminar_Clicked(object sender, EventArgs e)
        {
            EliminarPersonaje view = new EliminarPersonaje();
            PersonajeModel viewmodel = new PersonajeModel();
            int num = int.Parse(this.cajanumero.Text);
            Personaje personaje = this.repo.BuscarPersonaje(num);
            viewmodel.Personaje = personaje;
            view.BindingContext = viewmodel;
            await Navigation.PushModalAsync(view);
        }

        private async void botonInsertar_Clicked(object sender, EventArgs e)
        {
            InsertPersonaje view = new InsertPersonaje();
            await Navigation.PushModalAsync(view);
        }

        private async void botonMostrar_Clicked(object sender, EventArgs e)
        {
            Personajes view = new Personajes();
            await Navigation.PushModalAsync(view);
        }
    }
}
