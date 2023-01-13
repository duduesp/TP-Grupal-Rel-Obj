using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura
{
    public class Factura
    {
        public Cliente Cliente { get; set; }
        public Empleado Empleado { get; set; }

        public double Iva { get; set; }
        public List<DetalleFactura> DetallesFacturas { get; set; }  
    }
}
