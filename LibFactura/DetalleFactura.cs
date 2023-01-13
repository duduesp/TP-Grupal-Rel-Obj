using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura
{
    public class DetalleFactura
    {
        public Factura Factura { get; set; }
        public int NumeroFactura { get; set; }
        public Producto Producto { get; set; }

        public DetalleFactura(int numerofactura)
        {
            NumeroFactura = numerofactura;
        }
    }
}
