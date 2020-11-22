using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    #pragma warning disable CS0660
    #pragma warning disable CS0661
    public class Cliente:Persona
    {
        static int idAuto=100;
        int idCliente;
        public Cliente(string nombre, string apellido, int dni) : base(nombre,apellido,dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            idAuto++;
            this.idCliente = idAuto;
        }

        public int IdCliente
        {
            get { return this.idCliente; }
        }

        public static bool operator == (List <Cliente> listaClientes, Cliente unCliente)
        {
            for(int i=0;i<listaClientes.Count;i++)
            {
                if(listaClientes[i].dni == unCliente.dni)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator != (List <Cliente> listaClientes, Cliente unCliente)
        {
            return !(listaClientes == unCliente);
        }
    }
}
