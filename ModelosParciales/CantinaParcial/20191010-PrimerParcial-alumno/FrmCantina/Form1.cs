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
namespace FrmCantina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.barra1.SetCantina = Cantina.GetCantina(10);
            this.cmbBoxTipoBotella.DataSource = Enum.GetValues(typeof(Botella.Tipo));
            this.cmbBoxTipoBotella.SelectedItem = Botella.Tipo.Plastico;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
         
        }

        private void cmbBoxTipoBotella_SelectedIndexChanged(object sender, EventArgs e)
        {
            Botella.Tipo tipo;
            Enum.TryParse<Botella.Tipo>(cmbBoxTipoBotella.SelectedValue.ToString(), out tipo);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cantina cantina = Cantina.GetCantina(10);
            Botella botella;
            if(radioButtonCerveza.Checked)
            {
                Botella.Tipo tipo;
                Enum.TryParse<Botella.Tipo>(cmbBoxTipoBotella.SelectedValue.ToString(), out tipo);
                botella = new Cerveza((int)numCapacidad.Value, (int)numContenido.Value, txtboxMarca.Text, (Botella.Tipo)cmbBoxTipoBotella.SelectedValue);
            }

            else
            {
                botella = new Agua((int)numCapacidad.Value, (int)numContenido.Value, txtboxMarca.Text);
            }

            barra1.AgregarBotella(botella);
                 
        }
    }
}
