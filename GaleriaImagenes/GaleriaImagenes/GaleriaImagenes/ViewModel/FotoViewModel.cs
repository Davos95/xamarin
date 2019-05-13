using GaleriaImagenes.Base;
using GaleriaImagenes.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GaleriaImagenes.ViewModel
{
    public class FotoViewModel: ViewModelBase
    {


        private Foto _Foto;

        public Foto Foto
        {
            get { return this._Foto; }
            set
            {
                this._Foto = value;
                OnPropertyChanged("Foto");
            }
        }



    }
}
