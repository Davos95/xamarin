using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using ArchivosXamarin.Models;
using System.IO;
using Newtonsoft.Json;

namespace ArchivosXamarin.Repositories
{
    public class RepositorySeries
    {
        private String LeerFileAssembly()
        {
            String nombrerecurso =
                "ArchivosXamarin.Ficheros.series.json";
            var assembly =
                IntrospectionExtensions.GetTypeInfo(typeof(RepositorySeries))
                .Assembly;
            Stream stream = assembly.GetManifestResourceStream(nombrerecurso);
            String contenido = "";
            using (var reader = new StreamReader(stream))
            {
                contenido = reader.ReadToEnd();
            }
            return contenido;
        }

        private String LeerFileAzure()
        { return null; }

        public List<Serie> GetSeries()
        {
            String datosjson = this.LeerFileAssembly();
            List<Serie> series =
                JsonConvert.DeserializeObject<List<Serie>>(datosjson);
            return series;
        }
    }
}
