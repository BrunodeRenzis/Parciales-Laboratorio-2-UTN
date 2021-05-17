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

namespace PrimerParcialBrunoDeRenzis
{
    public partial class FrmBuscador : Form
    {
        
        public FrmBuscador()
        {
            InitializeComponent();
        }

        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtBoxNombre.Text.Length>0)
                rtbPersonaje.Text= Personaje.BuscarPersonaje(Marvel.listaPersonajes,txtBoxNombre.Text);
            

            else
                MessageBox.Show("No se ha ingresado ningún texto","Error");
            
        }

        
    }
}
