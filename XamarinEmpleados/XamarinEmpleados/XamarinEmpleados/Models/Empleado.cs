using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinEmpleados.Models
{
    public class Empleado
    {
        [JsonProperty("idEmpleado")]
        public int IdEmpleado { get; set; }
        [JsonProperty("apellido")]
        public String Apellido { get; set; }
        [JsonProperty("oficio")]
        public String Oficio { get; set; }
        [JsonProperty("salario")]
        public int Salario { get; set; }
    }
}
