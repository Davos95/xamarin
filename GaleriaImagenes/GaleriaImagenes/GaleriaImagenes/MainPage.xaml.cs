using GaleriaImagenes.Dependencies;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GaleriaImagenes
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.botonimagen.Clicked += async (sender, e) =>
            {
                botonimagen.IsEnabled = false;
                Stream stream = await DependencyService.Get<IGaleriaImagenes>().GetFotoAsync();

                if (stream != null)
                {
                    Image image = new Image
                    {
                        Source = ImageSource.FromStream(() => stream),
                        BackgroundColor = Color.Gray
                    };

                }
                else
                {
                    botonimagen.IsEnabled = true;
                }
            };
        }
    }
}
