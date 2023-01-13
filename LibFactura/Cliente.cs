using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura
{
    public class Cliente:Persona
    {
        public Usuario Usuario { get; set;}

        public int nroCliente { get; set;}

        public List <Factura> Facturas { get; set;}

        public Cliente(string nombre, string apellido, int dni, int nrocliente):base(nombre, apellido, dni)
        {
            nroCliente = nrocliente;
        }
    }
}
