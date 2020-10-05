using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace MenuVentas
{
    public partial class FormVentas : Form
    {
        List<Venta> listaVenta;
        Venta ticket;
        Empleado unEmpleado;
        Cliente unCliente;
        double monto;
        public FormVentas()
        {
            InitializeComponent();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            
            
                this.boxProducto.DataSource = KwikEMart.listaProductos;
                this.boxProducto.DisplayMember = "Descripcion";
                       
            
        }

        private void boxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Despedida()
        {
            SoundPlayer goodbyeSound = new SoundPlayer();
            goodbyeSound.SoundLocation = "C:/Users/Bruno/Desktop/apuChau.wav";
            goodbyeSound.Play();
            MessageBox.Show("Gracias vuelva prontos", "Kwik e Mart");
        }
        private void btnVenta_Click(object sender, EventArgs e)
        {

            Despedida();
            this.Close();
        }

        private void txtboxCantidad_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtboxNombre.Text = "";
            this.txtboxApellido.Text = "";
            this.txtboxCantidad.Text = "";
            this.boxProducto.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }
    }
}