using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinEmpleados.Models;
using XamarinEmpleados.ViewModels;

namespace XamarinEmpleados.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EmpleadosView : ContentPage
	{
		public EmpleadosView ()
		{
			InitializeComponent ();

		}
        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Empleado empleado = e.SelectedItem as Empleado;
            EmpleadoViewModel viewModel = new EmpleadoViewModel();
            viewModel.Empleado = empleado;
            EmpleadoView view = new EmpleadoView();
            view.BindingContext = viewModel;
            await Navigation.PushModalAsync(view);
        }
	}
}