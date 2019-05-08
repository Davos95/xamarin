using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasesDatos.Models
{
    [Table("DEPT")]
    public class Departamento
    {
        [PrimaryKey]
        public int Numero { get; set; }
        public String Nombre { get; set; }
        public String Localidad { get; set; }
    }
}
