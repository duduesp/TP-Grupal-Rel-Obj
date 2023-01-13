using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura
{
    public class Empleado:Persona
    {
        public int Legajo { get; set; }
        public Empleado(string nombre, string apellido, int dni, int legajo) : base(nombre, apellido, dni)
        {
            Legajo = legajo;
        }
        public List<Factura> Facturas { get; set; }
    }
}
