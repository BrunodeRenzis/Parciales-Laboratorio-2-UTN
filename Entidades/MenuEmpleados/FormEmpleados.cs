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
namespace MenuEmpleados
{
    public partial class FormEmpleados : Form
    {
        string auxUsuario;
        
        public string AuxUsuario
        {
            get { return auxUsuario; }
        }
        public FormEmpleados()
        {
            InitializeComponent();
        }

        

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool flagUsuario = false;
            foreach (var item in KwikEMart.loginEmpleado)
            {
                if (item.Key == this.txtboxUsuario.Text)
                {
                    if (item.Value == this.txtboxContraseña.Text)
                    {
                        flagUsuario = true;
                        auxUsuario = item.Key;
                        DialogResult = DialogResult.OK;
                    }
                }
            }
            if (!flagUsuario)
            {
                MessageBox.Show("Usuario o clave incorrectos", "Kwik e Mart");
            }
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            KwikEMart.HarcodearUsuario(); //valida los datos a ingresar en el login.
        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }
    }
}
