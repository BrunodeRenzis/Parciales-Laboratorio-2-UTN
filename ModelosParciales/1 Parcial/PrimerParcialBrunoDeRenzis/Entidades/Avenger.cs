using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Avenger : Personaje
    {
        Marvel.EEquipamiento equipamiento;

        /// <summary>
        /// Constructor de la clase avenger.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="hab"></param>
        /// <param name="equipo"></param>
        public Avenger(string nombre,List<Marvel.EHabilidades> hab, Marvel.EEquipamiento equipo):base(nombre,hab)
        {
            this.equipamiento = equipo;
        }


        /// <summary>
        /// Sobreescritura de la propiedad Nombre
        /// </summary>
        protected override string Nombre => $"Mi nombre es: {this.nombre} y si no puedo proteger la tierra la vengaré";

        /// <summary>
        /// Sobreescritura del método tostring agregando el equipamiento.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Equipamiento: {this.equipamiento}");
            return sb.ToString();
        }
    }
}
