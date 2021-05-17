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
namespace FrmTest
{
    public partial class frmTester : Form
    {
        Vendedor vendedor;
        public frmTester()
        {
            InitializeComponent();
            vendedor = new Vendedor("Bruno de Renzis");
        }

        private void FrmTester_Load(object sender, EventArgs e)
        {
            Biografia p1 = (Biografia)"Life (Keith Richards)";
            Biografia p2 = new Biografia("White line fever (Lemmy)", 5);
            Biografia p3 = new Biografia("Commando (Johnny Ramone)", 2, 5000);
            Comic p4 = new Comic("La Muerte de Superman (Superman)", true, 1, 1850);
            Comic p5 = new Comic("Año Uno (Batman)", false, 3, 1270);

            this.lstStock.Items.Add(p1);
            this.lstStock.Items.Add(p2);
            this.lstStock.Items.Add(p3);
            this.lstStock.Items.Add(p4);
            this.lstStock.Items.Add(p5);
        }

        private bool CerrarFormConfirm()
        {
            DialogResult dres;
            dres = MessageBox.Show("Desea salir?", "Tienda Bruno", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dres == DialogResult.Yes)
            {
                this.Close();
                return true;
            }

            return false;
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            rtbInforme.Text = Vendedor.InformeDeVentas(vendedor);
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if(vendedor+(Publicacion)this.lstStock.SelectedItem)
            {
                MessageBox.Show("Venta exitosa","Tienda Bruno");
            }

            else
            {
                MessageBox.Show("Sin Stock", "Tienda Bruno",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            CerrarFormConfirm();
        }

        //No funciona esta poronga
        private void frmTester_FormClosing(object sender, FormClosingEventArgs e)
        {
            CerrarFormConfirm();
        }


    }
}
