using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura
{
    public class Producto
    {
        public List<DetalleFactura> DetallesFacturas { get; set; }
        public Categoria Categoria { get; set; }

        public string Nombre { get; set; }
        public int Precio { get; set; }

        public Producto(string nombre, int precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }
}
