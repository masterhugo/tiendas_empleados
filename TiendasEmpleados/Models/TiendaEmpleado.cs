using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiendasEmpleados.Models
{
    public class TiendaEmpleado
    {
        Tienda tienda { get; set; }
        Empleado empleado { get; set; }
        DateTime diaTrabajado { get; set; }
    }
}