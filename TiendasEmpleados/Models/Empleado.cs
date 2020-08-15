using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiendasEmpleados.Models
{
    public class Empleado
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        public string documento { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string genero { get; set; }
        public Cargo cargo { get; set; }
    }
}