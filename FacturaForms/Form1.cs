using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibFactura;

namespace FacturaForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Categoria hardware = new Categoria("Hw");
            hardware.Nombre = "Hw";

            Producto producto1 = new Producto("Placa de video",50000);
            producto1.Categoria = hardware;

            Producto producto2 = new Producto("Procesador",30000);
            producto1.Categoria = hardware;

            List<Producto> productos = new List<Producto> { producto1, producto2 };
            ProductosGrid.DataSource = productos;
        }
    }
}
