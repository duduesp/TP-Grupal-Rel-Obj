using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura
{
    public class Cliente
    {
        public Usuario Usuario { get; set;}

        public string Nombre { get; set;}
        public string Apellido { get; set;}
        public int Dni { get; set;}

        public List <Factura> Facturas { get; set;}
    }
}
