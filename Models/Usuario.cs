using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FerroApp.Consume.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
    }
}
