using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using System.Linq;
using ArchivosXamarin.Models;

namespace ArchivosXamarin.Repositories
{
    public class RepositoryPeliculas
    {
        private String LeerFicheroAssembly()
        {
            String nombrerecurso =
                "ArchivosXamarin.Ficheros.EscenasPeliculas.xml";
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

        public List<Pelicula> GetPeliculas()
        {
            String datosxml = this.LeerFicheroAssembly();
            //CREAMOS UN NUEVO DOCUMENTO XML A PARTIR
            //DEL STREAM DE AZURE
            XDocument documento = XDocument.Parse(datosxml);
            var consulta = from datos in documento.Descendants("pelicula")
                           select new Pelicula
                           {
                               Titulo = (string)datos.Element("titulo"),
                               TituloOriginal = (string)datos.Element("titulooriginal"),
                               Descripcion = (string)datos.Element("descripcion"),
                               Poster = (string)datos.Element("poster"),
                               Escenas = new List<Escena>(from esc in datos.Descendants("escena")
                                                          select new Escena
                                                          {
                                                              TituloEscena = esc.Element("tituloescena").Value,
                                                              Descripcion = esc.Element("descripcion").Value,
                                                              ImagenEscena = esc.Element("imagen").Value
                                                          })
                           };
            return consulta.ToList();
        }
    }
}


