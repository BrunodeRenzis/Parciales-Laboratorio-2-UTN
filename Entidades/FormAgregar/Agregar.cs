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
        Producto auxProducto;
        
        public Agregar()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombreProducto = this.txtBoxNombre.Text;



            try
            {
                switch ((Producto.tipoProductos)this.cmbBoxTipo.SelectedValue)
                {
                    case Producto.tipoProductos.perecedero:
                        auxProducto = new ProductoPerecedero(nombreProducto, double.Parse(this.txtBoxPrecio.Text), int.Parse(this.txtBoxCantidad.Text), (Producto.tipoProductos)this.cmbBoxTipo.SelectedValue, "20-oct-2020");


                        if (KwikEMart.listaProductos + auxProducto)
                        {
                            MessageBox.Show("Producto agregado", "Kwik E Mart");
                        }

                        else
                        {
                            MessageBox.Show("Producto ya existente", "Kwik E Mart");
                        }
                        break;
                    case Producto.tipoProductos.noPerecedero:
                        auxProducto = new ProductoNoPerecedero(nombreProducto, double.Parse(this.txtBoxPrecio.Text), int.Parse(this.txtBoxCantidad.Text), (Producto.tipoProductos)this.cmbBoxTipo.SelectedValue);
                        if (KwikEMart.listaProductos + auxProducto)
                        {
                            MessageBox.Show("Producto agregado", "Kwik E Mart");
                        }

                        else
                        {
                            MessageBox.Show("Producto ya existente", "Kwik E Mart");
                        }
                        break;

                }




            }
            catch(Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
            
            this.Close();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            this.txtBoxCantidad.Text = "";
            this.txtBoxNombre.Text = "";
            this.txtBoxPrecio.Text = "";
            this.cmbBoxTipo.DataSource = Enum.GetValues(typeof(Producto.tipoProductos));
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

        private void cmbBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
