using PostImagenes.Dependencies;
using PostImagenes.Models;
using PostImagenes.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PostImagenes
{
    public partial class MainPage : ContentPage
    {
        public FotosViewModel listaFotos;
        public MainPage()
        {
            InitializeComponent();
            listaFotos = new FotosViewModel();
            //this.botonimagen.Clicked += async (sender, e) =>
            //{
            //    Stream stream = await DependencyService.Get<IGaleriaImagenes>().GetFotoAsync();

            //    if (stream != null)
            //    {
            //        Foto foto = new Foto();

            //        foto.name = "hola";
                    
            //        foto.Imagen.Source = ImageSource.FromStream(() => stream);

            //        this.preview.Source = foto.Imagen.Source;

            //        this.listaFotos.Fotos.Add(foto);
            //        this.lstImagenes.ItemsSource = this.listaFotos.Fotos;
                    
            //    }
            //};


        }
    }
}
