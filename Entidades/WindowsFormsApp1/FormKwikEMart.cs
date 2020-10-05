using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenuProductos;
using Entidades;
using MenuVentas;
using MenuClientes;
using FormAgregar;
using MenuEmpleados;
using System.Media;

namespace WindowsFormsApp1
{

    public partial class FormKwikEMart : Form
    {
        FormEmpleados formEmpleados = new FormEmpleados();
        
        public FormKwikEMart()
        {
            InitializeComponent();
        }

        private void FormKwikEMart_Load(object sender, EventArgs e)
        {
            KwikEMart.HardcodeoListados();
            if(formEmpleados.ShowDialog()== DialogResult.OK)
            {
                Validaciones.ValidarLogin(formEmpleados.AuxUsuario);
            }
            else
            {
                this.Close();
            }
            this.lblNombreUsuario.Text = formEmpleados.AuxUsuario;
            SoundPlayer soundWelcome = new SoundPlayer();
            soundWelcome.SoundLocation = "C:/Users/Bruno/Desktop/apu.wav";
            soundWelcome.Play();
        }


        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes();
            formClientes.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormProductos formProductos = new FormProductos();
            formProductos.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FormVentas formVentas = new FormVentas();
            formVentas.Show();
            
        }

    }
}