using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador_de_empleados
{
    public abstract class Persona
    {
        short edad;
        string nombre;

        protected Persona(short edad, string nombre)
        {
            this.edad = edad;
            this.nombre = nombre;
        }

        public short Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public abstract bool Validar();

        public static explicit operator string(Persona persona)
        {
            return persona.Nombre;
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Edad: {this.Edad}");
            return sb.ToString();
        }
    }
}
