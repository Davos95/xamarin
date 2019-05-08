using System;
using System.Collections.Generic;
using System.Text;

namespace PaginasBinding.Models
{
    public class Jugador
    {
        public Jugador()
        {
            this.Nombre = "Guti";
            this.Equipo = "Real Madrid";
            this.Imagen = "Mi imagen";
            this.Descripcion = "Genio";
        }
        public String Nombre { get; set; }
        public String Equipo { get; set; }
        public String Imagen { get; set; }
        public String Descripcion { get; set; }
    }
}
