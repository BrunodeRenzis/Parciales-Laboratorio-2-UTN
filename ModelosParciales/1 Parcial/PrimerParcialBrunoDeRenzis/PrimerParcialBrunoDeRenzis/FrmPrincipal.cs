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
    public partial class FrmPrincipal : Form
    {
        bool status;
        FrmBuscador buscador;
        public FrmPrincipal()
        {
            InitializeComponent();
            status = true;
        }

        /// <summary>
        /// Carga de objetos a través de la propiedad Personaje al form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Marvel.Personaje = new Avenger("AnthonyStark", new List<Marvel.EHabilidades>() { Marvel.EHabilidades.InteligenciaSuperior }, Marvel.EEquipamiento.Armadura); 
            Marvel.Personaje = new Avenger("AnthonyStark", new List<Marvel.EHabilidades>() { Marvel.EHabilidades.InteligenciaSuperior }, Marvel.EEquipamiento.Armadura); 
            Marvel.Personaje = new Avenger("Dr Banner", new List<Marvel.EHabilidades>() { Marvel.EHabilidades.InteligenciaSuperior }, Marvel.EEquipamiento.Transformacion); 
            Marvel.Personaje = new Avenger("Dr Banner", new List<Marvel.EHabilidades>() { Marvel.EHabilidades.InteligenciaSuperior }, Marvel.EEquipamiento.Transformacion); 
            Marvel.Personaje = new Avenger("NatashaRomanoff ", new List<Marvel.EHabilidades>() { Marvel.EHabilidades.Sigilio, Marvel.EHabilidades.Astucia }, Marvel.EEquipamiento.ArtesMarciales);
            Marvel.Personaje = new Avenger("Thor", new List<Marvel.EHabilidades>() { Marvel.EHabilidades.Rayos, Marvel.EHabilidades.Volar }, Marvel.EEquipamiento.Martillo);
            Marvel.Personaje = new Avenger("Thor", new List<Marvel.EHabilidades>() { Marvel.EHabilidades.Rayos, Marvel.EHabilidades.Volar }, Marvel.EEquipamiento.Martillo);


            Marvel.Personaje = new Enemigo("Thanos", new List<Marvel.EHabilidades>() { Marvel.EHabilidades.SuperFuerza, Marvel.EHabilidades.Astucia, Marvel.EHabilidades.Resistencia }, "Obtener las infinitystones y un te de vainilla"); 
            Marvel.Personaje = new Enemigo("Ultron", new List<Marvel.EHabilidades>() { Marvel.EHabilidades.SuperFuerza, Marvel.EHabilidades.Astucia, Marvel.EHabilidades.Volar }, "Exterminar a los humanos"); 
            Marvel.Personaje = new Enemigo("Loki", new List<Marvel.EHabilidades>() { Marvel.EHabilidades.Astucia }, "Dominar los 9 reinos");

        }

        /// <summary>
        /// Despliega a partir de un click la información de los personajes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
      

  

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (status)
            {
                this.rtbPersonajes.Text = Marvel.MostrarInformacion();
                this.btnMostrar.Text = "Ocultar personajes";
                status = false;
            }
            else
            {
                this.rtbPersonajes.Text = String.Empty;
                this.btnMostrar.Text = "Mostrar personajes";
                status = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscador = new FrmBuscador();
            buscador.ShowDialog();
        }
    }
}
