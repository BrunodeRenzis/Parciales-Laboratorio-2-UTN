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
using FormAgregar;
namespace MenuProductos
{
   
    public partial class FormProductos : Form
    {

        Agregar formAgregar = new Agregar();
        public FormProductos()
        {
            InitializeComponent();
        }

        void CargarDatagrid()
        {
            this.dtgvProductos.DataSource = null;
            this.dtgvProductos.DataSource = KwikEMart.listaProductos;
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            
            CargarDatagrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAgregar.ShowDialog();
            CargarDatagrid();

        }


        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stockTotalDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int stockTotal=KwikEMart.StockTotal();
            MessageBox.Show("Hay un total de "+stockTotal+" Productos", "Productos");
        }

        private void todosLosProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarDatagrid();
        }

        private void productosConMásDe10UnidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dtgvProductos.DataSource = null;
            this.dtgvProductos.DataSource = KwikEMart.StockMennosDe10Unidades();
            
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productosPerecederosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dtgvProductos.DataSource = null;
            this.dtgvProductos.DataSource = KwikEMart.ProductosPerecederos();
        }

        private void productosNoPerecederosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dtgvProductos.DataSource = null;
            this.dtgvProductos.DataSource= KwikEMart.ProductosNoPerecederos();
        }
    }
}
