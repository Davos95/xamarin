using ArchivosXamarin.Base;
using ArchivosXamarin.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ArchivosXamarin.ViewModels
{
    public class FicheroModel: ViewModelBase
    {
        //NECESITAMOS EL REPO PARA RECUPERAR EL CONTENIDO
        RepositoryFicheros repo;
        public FicheroModel()
        {
            this.repo = new RepositoryFicheros();
        }

        public Command LeerFichero
        {
            get
            {
                return new Command(() => {
                    //CAMBIAMOS LA PROPIEDAD CONTENIDO 
                    //PARA DIBUJAR EN LA VISTA
                    this.Contenido = this.repo.LeerFicheroAssembly();
                });
            }
        }
        //NECESITAMOS UNA PROPIEDAD PARA EL CONTENIDO
        //DEL FICHERO
        private String _Contenido;
        public String Contenido
        {
            get { return this._Contenido; }
            set {
                this._Contenido = value;
                OnPropertyChanged("Contenido");
            }
        }
    }
}
