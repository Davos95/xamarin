using ArchivosXamarin.Base;
using ArchivosXamarin.Models;
using ArchivosXamarin.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ArchivosXamarin.ViewModels
{
    public class PeliculasViewModel: ViewModelBase
    {
        RepositoryPeliculas repo;

        public PeliculasViewModel()
        {
            this.repo = new RepositoryPeliculas();
            List<Pelicula> lista = this.repo.GetPeliculas();
            this.Peliculas = new ObservableCollection<Pelicula>(lista);
        }

        private ObservableCollection<Pelicula> _Peliculas;
        public ObservableCollection<Pelicula> Peliculas
        {
            get { return this._Peliculas; }
            set
            {
                this._Peliculas = value;
                OnPropertyChanged("Peliculas");
            }
        }

        //NECESITAMOS UNA PROPIEDAD PARA PODER OBTENER
        //EL ELEMENTO SELECCIONADO DEL LISTVIEW
        //DICHA PROPIEDAD DEBE SER DEL MISMO TIPO
        //QUE LA COLECCION DEL LISTVIEW
        private Pelicula _PeliculaSeleccionada;
        public Pelicula PeliculaSeleccionada
        {
            get { return this._PeliculaSeleccionada; }
            set
            {
                this._PeliculaSeleccionada = value;
                OnPropertyChanged("PeliculaSeleccionada");
            }
        }
    }
}
