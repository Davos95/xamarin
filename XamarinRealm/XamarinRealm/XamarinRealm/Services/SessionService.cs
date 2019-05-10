using System;
using System.Collections.Generic;
using System.Text;
using XamarinRealm.Models;

namespace XamarinRealm.Services
{
    public class SessionService
    {
        //CREAMOS UNA COLECCION PAA ALMACENAR DATOS ENTRE TODA LA APP
        public List<String> Datos { get; set; }
        public List<Producto> Productos { get; set; }
        public SessionService()
        {
            this.Datos = new List<string>();
            this.Productos = new List<Producto>();

        }
    }
}
