using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;

namespace ArchivosXamarin.Repositories
{
    public class RepositoryFicheros
    {
        public String LeerFicheroAssembly()
        {
            String nombrerecurso =
                "ArchivosXamarin.Ficheros.documento.txt";
            var assembly =
                IntrospectionExtensions.GetTypeInfo(typeof(RepositoryFicheros))
                .Assembly;
            Stream stream =
                assembly.GetManifestResourceStream(nombrerecurso);
            String contenido = "";
            using (StreamReader reader = new StreamReader(stream))
            {
                contenido = reader.ReadToEnd();
            }
            return contenido;
        }
    }
}
