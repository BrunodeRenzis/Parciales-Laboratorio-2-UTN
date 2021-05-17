using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class Enemigo : Personaje
    {
        string objetivo;

        /// <summary>
        /// Constructor de la clase Enemigo
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="hab"></param>
        /// <param name="objetivo"></param>
        public Enemigo(string nombre, List<Marvel.EHabilidades> hab, string objetivo) : base(nombre, hab)
        {
            this.objetivo = objetivo;
        }

        /// <summary>
        /// Sobre escritura de la propiedad Nombre
        /// </summary>
        protected override string Nombre => $"Mi nombre es: {this.nombre} y los voy a hacer puré";

        /// <summary>
        /// Sobreescritura del método tostring agregándole el objetivo del villano.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.ToString()}");
            sb.AppendLine($"Objetivo: {this.objetivo}");
            return sb.ToString();
        }
    }
}
