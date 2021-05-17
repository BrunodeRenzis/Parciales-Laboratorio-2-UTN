using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComiqueriaLogic;
namespace ComiqueriaApp
{
    public partial class VentasForm : Form
    {
        Comiqueria comiqueria;
        Producto producto;
        public VentasForm (Producto producto, Comiqueria comiqueria)
        {
            InitializeComponent();
            this.comiqueria = comiqueria;
            this.producto = producto;
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            this.lblDescripcion.Text = this.producto.Descripcion;
            this.lblPrecio.Text = "Precio final: " + Venta.CalcularPrecioFinal(this.producto.Precio, 1);
        }

        private void numericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            this.lblPrecio.Text = $"Precio Final: {Venta.CalcularPrecioFinal(producto.Precio, (int)this.numericUpDownCantidad.Value)}";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if ((int)this.numericUpDownCantidad.Value <= producto.Stock)
            {
                producto.Stock -= (int)this.numericUpDownCantidad.Value;
                MessageBox.Show("Venta exitosa");
                this.Close();
            }

            else
            {
                MessageBox.Show("No hay stock de este libro");
            }
        }
    }
}
