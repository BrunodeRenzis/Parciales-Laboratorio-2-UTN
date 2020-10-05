using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace FormAgregar
{

    public partial class Agregar : Form
    {
        
        public Agregar()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int.Parse(this.txtBoxCantidad.Text);
            double.Parse(this.txtBoxPrecio.Text);
            string nombreProducto = this.txtBoxNombre.Text;
           
            KwikEMart.listaProductos.Add(new Producto(nombreProducto, double.Parse(this.txtBoxPrecio.Text),int.Parse(this.txtBoxCantidad.Text)));
            this.Close();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            this.txtBoxCantidad.Text = "";
            this.txtBoxNombre.Text = "";
            this.txtBoxPrecio.Text = "";
        }

        private void txtBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }
    }
}
