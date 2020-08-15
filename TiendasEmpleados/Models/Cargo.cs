using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiendasEmpleados.Models
{
    public class Cargo
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int salario { get; set; }

    }
}