using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado:Persona
    {
        int idEmpleado;
        string usuario;
        public Empleado(string nombre,string apellido, int dni,string usuario,int idEmpleado):base(nombre,apellido,dni)
        {
            this.idEmpleado = idEmpleado;
            this.usuario = usuario;
        }

        public int IdEmpleado
        {
            get { return this.idEmpleado; }
        }

        public string Usuario
        {
            get { return this.usuario; }
        }



    }
}