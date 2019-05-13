using PostImagenes.Base;
using PostImagenes.Dependencies;
using PostImagenes.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace PostImagenes.ViewModel
{
    public class FotosViewModel: ViewModelBase
    {
        public FotosViewModel()
        {
            this.Fotos = new ObservableCollection<Foto>();
        }

        private ObservableCollection<Foto> _Fotos;
        public ObservableCollection<Foto> Fotos
        {
            get { return this._Fotos; }
            set { this._Fotos = value; OnPropertyChanged("Fotos"); }
        }

        public Command CargarFoto
        {
            get
            {
                return new Command(async () =>
                {
                    Stream stream = await DependencyService.Get<IGaleriaImagenes>().GetFotoAsync();
                    
                        if (stream != null)
                        {
                            Foto foto = new Foto();
                            foto.Imagen.Source = ImageSource.FromStream(() => stream);

                            foto.name = "none";
                            

                            this.Fotos.Add(foto);
                        }
                    
                    
                    
                });
            }
        }
    }
}
