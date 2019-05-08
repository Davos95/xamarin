using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamarinRealm.Base;
using XamarinRealm.Models;
using XamarinRealm.Repository;

namespace XamarinRealm.ViewModels
{
    public class PersonajesModel: ViewModelBase
    {

        public PersonajesModel()
        {
            RepositoryRealm repo = new RepositoryRealm();
            List<Personaje> personajes = repo.GetPersonajes();
            this.Personajes = new ObservableCollection<Personaje>(personajes);
        }

        private ObservableCollection<Personaje> _Personajes;

        public ObservableCollection<Personaje> Personajes
        {
            get
            {
                return this._Personajes;
            }
            set
            {
                this._Personajes = value;
                OnPropertyChanged("Personajes");
            }
        }

    }
}
