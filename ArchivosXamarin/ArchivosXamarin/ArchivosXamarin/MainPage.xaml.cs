using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Reflection;
using System.IO;

namespace ArchivosXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.botonleer.Clicked += Botonleer_Clicked;
        }

        private void Botonleer_Clicked(object sender, EventArgs e)
        {
            //NECESITAMOS EL ENSAMBLADO DE LA APLICACION
            //APK ANDROID, IPA IOS, EXE UWP
            var assembly =
                IntrospectionExtensions.GetTypeInfo
                (typeof(MainPage)).Assembly;
            //PARA RECUPERAR EL FILE DEBEMOS PONER TODA
            //LA RUTA CON NAMESPACE
            String rutarecurso =
                "ArchivosXamarin.Ficheros.documento.txt";
            //RECUPERAMOS EL STREAM DEL FICHERO
            Stream stream =
                assembly.GetManifestResourceStream(rutarecurso);
            //LEEMOS EL STREAM
            String contenido = "";
            using (var reader = new StreamReader(stream))
            {
                contenido = reader.ReadToEnd();
            }
            //DIBUJAMOS EN EL LABEL LOS DATOS
            this.lblcontenido.Text = contenido;
        }
    }
}
