using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinDoctores.Base;
using XamarinDoctores.Models;
using XamarinDoctores.Repositories;
using XamarinDoctores.Views;

namespace XamarinDoctores.ViewModel
{
    public class DoctoresViewModel: ViewModelBase
    {
        RepositoryDoctores repo;
        public DoctoresViewModel()
        {
            this.repo = new RepositoryDoctores();
            Task.Run(async () =>
            {
                List<Doctor> lista = await this.repo.GetDoctores();
                this.Doctores = new ObservableCollection<Doctor>(lista);
            });
        }

        public Command MostrarDetallesDoctor
        {
            get
            {
                return new Command(async (doctor) =>
                {
                    DetallesDoctor view = new DetallesDoctor();
                    DoctorViewModel viewModel = new DoctorViewModel();
                    //NOS FALTA EL DOCTOR
                    viewModel.Doctor = doctor as Doctor;
                    view.BindingContext = viewModel;
                    await Application.Current.MainPage.Navigation.PushModalAsync(view);

                });
            }
        }

        private ObservableCollection<Doctor> _Doctores;
        public ObservableCollection<Doctor> Doctores
        {
            get { return this._Doctores; }
            set
            {
                this._Doctores = value;
                OnPropertyChanged("Doctores");
            }
        }
    }
}
