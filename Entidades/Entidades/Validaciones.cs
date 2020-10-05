using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Entidades
{
    public static class Validaciones
    {
        public static bool ValidarCliente(Cliente auxCliente)
        {
            if (auxCliente.Apellido == "Simpson")
            {
                return true;
            }

            return false;
        }
        public static void ValidarLogin(string auxUsuario)
        {
            foreach (var item in KwikEMart.listaEmpleados)
            {
                if (item.Usuario == auxUsuario)
                {
                    KwikEMart.empleadoLogueado = item;
                }
            }
        }
        public static bool ValidarVenta()
        {

            return false;
        }


    }
}
