using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinEmpleados.Base;
using XamarinEmpleados.Models;
using XamarinEmpleados.Repositories;
using XamarinEmpleados.Views;

namespace XamarinEmpleados.ViewModels
{
    public class EmpleadosViewModel: ViewModelBase
    {
        RepostioryEmpleados repo;

        public EmpleadosViewModel()
        {
            this.repo = new RepostioryEmpleados();
            Task.Run(async () =>
            {
                List<Empleado> lista = await this.repo.GetEmpleados();
                this.Empleados = new ObservableCollection<Empleado>(lista);
            });
        }

        public Command MostrarDetalles
        {
            get
            {
                return new Command(async () =>
                {
                    EmpleadoView view = new EmpleadoView();
                    EmpleadoViewModel viewModel = new EmpleadoViewModel();
                    viewModel.Empleado = this.EmpleadoSeleccionado;
                    view.BindingContext = viewModel;
                    await Application.Current.MainPage.Navigation.PushModalAsync(view);
                });
            }
        }


        private ObservableCollection<Empleado> _Empleados;
        public ObservableCollection<Empleado> Empleados
        {
            get { return this._Empleados; }
            set
            {
                this._Empleados = value;
                OnPropertyChanged("Empleados");
            }
        }

        private Empleado _EmpleadoSeleccionado;
        public Empleado EmpleadoSeleccionado
        {
            get { return this._EmpleadoSeleccionado; }
            set
            {
                this._EmpleadoSeleccionado = value;
                OnPropertyChanged("EmpleadoSeleccionado");
            }
        }
    }
}
