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
    /*
    FALTA:
    1) SELECCIONAR UN ELEMENTO Y QUE CON DOBLE CLICK SE AGREGUE A LA LISTA.
    2) GUARDAR TODOS LOS ELEMENTOS EN UNA LISTA DE COMPRA.
    3) PEDIR LAS CANTIDADES.
    4) GENERAR TICKET DE VENTA.
    5) PEDIR NOMBRE Y APELLIDO DEL CLIENTE Y VERIFICAR SI EXISTE O NO PARA CREAR EL NUEVO CLIENTE.
    */
    public partial class FormVentas : Form
    {
        Empleado unEmpleado;
        Cliente unCliente;
        Venta unaVenta;
        List<VentaCliente>listaVenta;
        double monto;
        public FormVentas()
        {
            InitializeComponent();
            monto = 0;
            listaVenta = new List<VentaCliente>();

        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            CargarDatagridProductos();
        }

        private void Despedida()
        {
            SoundPlayer despedida = new SoundPlayer();
            despedida.SoundLocation = "C:/Users/Bruno/Desktop/apuChau.wav";
            despedida.Play();
            MessageBox.Show("Gracias vuelva prontos", "Kwik e Mart");
        }

        void CargarDatagridProductos()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = KwikEMart.listaProductos;
        }

        void CargarDatagridProductosSeleccionados()
        {
            this.dataGridView2.DataSource = null;
            this.dataGridView2.DataSource = KwikEMart.ticketVenta;
        }
        private void btnVenta_Click(object sender, EventArgs e)
        { 
            Despedida();
            this.Close();
        }

        

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double monto;
            double montoTotal=0;
            string desc;
            int idProd;
            int cant = int.Parse(this.TxtBoxCanditad.Text);

            desc = (string)dataGridView1.CurrentRow.Cells["Descripcion"].Value;
            monto = (double)dataGridView1.CurrentRow.Cells["Precio"].Value;
            idProd = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
            if (cant>0)
            {
                MessageBox.Show("Agregado","KwikEMart");
                
            }
            else
            {
                MessageBox.Show("Indique cantidad de unidades antes de agregar","KwikEMart");
            }

            for(int i=0;i<cant;i++)
            {
                listaVenta.Add(new VentaCliente(unEmpleado, unCliente, monto));
            }

            for(int i=0;i<KwikEMart.listaProductos.Count;i++)
            {
                if(idProd == KwikEMart.listaProductos[i].IdProducto)
                {
                    KwikEMart.listaProductos[i].Stock -= cant;
                }
            }

            montoTotal += cant * monto;
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}