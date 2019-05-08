using ArchivosXamarin.Base;
using ArchivosXamarin.Models;
using ArchivosXamarin.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ArchivosXamarin.ViewModels
{
    public class SeriesViewModel: ViewModelBase
    {
        RepositorySeries repo;

        public SeriesViewModel()
        {
            this.repo = new RepositorySeries();
            //CARGAMOS LA LISTA AL INSTANCIAR EL VIEWMODEL
            List<Serie> lista = this.repo.GetSeries();
            //PARA CONVERTIR CUALQUIER COLECCION A 
            //ObservableCollection SE UTILIZA SU
            //CONSTRUCTOR new ObservableCollection(ICollection)
            this.Series = new ObservableCollection<Serie>(lista);
        }

        //EN LAS VISTAS, AL REPRESENTAR MULTIPLES
        //DATOS SE UTILIZA LA COLECCION
        //ObservableCollection<T>
        //ES UNA COLECCION ESPECIFICA DE XAMARIN
        //Y VA MAS RAPIDA EN LOS DIBUJOS
        private ObservableCollection<Serie> _Series;
        public ObservableCollection<Serie> Series
        {
            get { return this._Series; }
            set
            {
                this._Series = value;
                OnPropertyChanged("Series");
            }
        }
    }
}
