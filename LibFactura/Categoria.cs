using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura
{
    public class Categoria
    {
        public List <Producto> Productos { get; set; }

        public string Nombre { get; set; }

        public Categoria(string nombre)
        {
            Nombre = nombre;
        }
    }
}
