﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiendasEmpleados.Models
{
    public class Tienda
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
    }
}