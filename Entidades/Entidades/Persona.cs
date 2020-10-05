using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int dni;

        public Persona(string nombre, string apellido, int dni)
        {
            this.dni = dni;
            this.apellido = apellido;
            this.nombre = nombre;
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public string Apellido
        {
            get { return apellido; }
        }

        public int Dni
        {
            get { return dni; }
        }

        public string NombreYApellido()
        {
            return string.Format($"El nombre es {this.nombre} y el apellido es {this.apellido}  ");
        }
    }

    
}
