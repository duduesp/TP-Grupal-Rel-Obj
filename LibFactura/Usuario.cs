using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura
{
    public class Usuario
    {
        public Cliente Cliente { get; set; }
        public string Nombre { get; set; }

        public Usuario(string nombre)
        {
            Nombre = nombre;
        }
    }
}
