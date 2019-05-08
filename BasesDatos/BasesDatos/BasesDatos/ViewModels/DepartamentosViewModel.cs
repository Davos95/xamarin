using BasesDatos.Base;
using BasesDatos.Models;
using BasesDatos.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BasesDatos.ViewModels
{
    public class DepartamentosViewModel: ViewModelBase
    {
        public DepartamentosViewModel()
        {
            RepositoryDepartamentos repo = new RepositoryDepartamentos();
            List<Departamento> lista = repo.GetDepartamentos();
            this.Departamentos =
                new ObservableCollection<Departamento>(lista);
        }

        private ObservableCollection<Departamento> _Departamentos;
        public ObservableCollection<Departamento> Departamentos
        {
            get { return this._Departamentos; }
            set {
                this._Departamentos = value;
                OnPropertyChanged("Departamentos");
            }
        }
    }
}
