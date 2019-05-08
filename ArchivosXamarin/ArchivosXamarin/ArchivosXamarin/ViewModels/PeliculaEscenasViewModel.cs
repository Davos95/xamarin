using ArchivosXamarin.Base;
using ArchivosXamarin.Models;
using ArchivosXamarin.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArchivosXamarin.ViewModels
{
    public class PeliculaEscenasViewModel: ViewModelBase
    {
        private Pelicula _Pelicula;
        public Pelicula Pelicula
        {
            get { return this._Pelicula; }
            set
            {
                this._Pelicula = value;
                OnPropertyChanged("Pelicula");
            }
        }
    }
}
