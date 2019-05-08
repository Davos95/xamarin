using ArchivosXamarin.Models;
using ArchivosXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ArchivosXamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PeliculasView : ContentPage
	{
		public PeliculasView ()
		{
			InitializeComponent ();
		}

        private async void ListView_ItemSelected(object sender
            , SelectedItemChangedEventArgs e)
        {
            //RECUPERAMOS LA PELICULA SELECCIONADA DE LA LISTA
            Pelicula peli = e.SelectedItem as Pelicula;
            //NECESITAMOS CREAR EL VIEWMODEL PARA CARRUSEL
            //Y ASOCIAR LA PELICULA
            PeliculaEscenasViewModel viewmodel = new PeliculaEscenasViewModel();
            //ALMACENAMOS LA PELI EN VIEWMODEL
            viewmodel.Pelicula = peli;
            CarruselEscenas view = new CarruselEscenas();
            //ENLAZAMOS EL VIEWMODEL CON LA VISTA
            view.BindingContext = viewmodel;
            await Navigation.PushModalAsync(view);
        }
    }
}