using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinRealm.Services
{
    public class SessionService
    {
        //CREAMOS UNA COLECCION PAA ALMACENAR DATOS ENTRE TODA LA APP
        public List<String> Datos { get; set; }
        public SessionService()
        {
            this.Datos = new List<string>();

        }
    }
}
