using BasesDatos.Base;
using BasesDatos.Models;
using BasesDatos.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BasesDatos.ViewModels
{
    public class DepartamentoModel: ViewModelBase
    {
        RepositoryDepartamentos repo;

        public DepartamentoModel()
        {
            this.repo = new RepositoryDepartamentos();
            this.Departamento = new Departamento(); 
        }

        public Command InsertarDepartamento
        {
            get
            {
                return new Command(() => {
                    this.repo.InsertarDepartamento(
                        this.Departamento.Numero, Departamento.Nombre
                        , Departamento.Localidad
                        );
                });
            }
        }
        public Command ModificarDepartamento
        {
            get {
                return new Command(() => {
                    this.repo.ModificarDepartamento(Departamento.Numero
                        , Departamento.Nombre, Departamento.Localidad);
                });
            }
        }

        public Command EliminarDepartamento
        {
            get
            {
                return new Command(() => {
                    this.repo.EliminarDepartamento(Departamento.Numero);
                });
            }
        }

        private Departamento _Departamento;
        public Departamento Departamento
        {
            get { return this._Departamento; }
            set
            {
                this._Departamento = value;
                OnPropertyChanged("Departamento");
            }
        }
    }
}
