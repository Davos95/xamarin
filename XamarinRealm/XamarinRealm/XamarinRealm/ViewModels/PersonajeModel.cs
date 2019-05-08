using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinRealm.Base;
using XamarinRealm.Models;
using XamarinRealm.Repository;
using XamarinRealm.Views;

namespace XamarinRealm.ViewModels
{
    public class PersonajeModel: ViewModelBase
    {
        RepositoryRealm repo;
        public PersonajeModel()
        {
            this.repo = new RepositoryRealm();
            this.Personaje = new Personaje();
            
        }

        public Command InsertarPersonaje
        {
            get
            {
                return new Command(() =>
                {
                    this.repo.InsertarPersonaje(this.Personaje.IdPersonaje, this.Personaje.Nombre, this.Personaje.Serie);
                });
            }
        }

        public Command ModificarPersonaje
        {
            get
            {
                return new Command(() =>
                {
                    this.repo.ModificarPersonaje(this.Personaje.IdPersonaje, this.Personaje.Nombre, this.Personaje.Serie);
                });
            }
        }

        public Command EliminarPersonaje
        {
            get
            {
                return new Command(() =>
                {
                    this.repo.EliminarPersonaje(this.Personaje.IdPersonaje);
                });
            }
        }

        private Personaje _Personaje;

        public Personaje Personaje
        {
            get { return this._Personaje; }
            set
            {
                this._Personaje = value;
                OnPropertyChanged("Personaje");
            }
        }


    }
}
