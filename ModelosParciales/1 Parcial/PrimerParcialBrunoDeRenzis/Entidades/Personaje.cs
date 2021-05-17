using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Personaje
    {
        protected string nombre;
        List<Marvel.EHabilidades> listaHabilidades;

        /// <summary>
        /// Constructor donde se inicializa la lista de habilidades
        /// </summary>
        private Personaje()
        {
            this.listaHabilidades = new List<Marvel.EHabilidades>();
        }

        /// <summary>
        /// Método que busca por nombre un personaje y retorna sus detalles. 
        /// </summary>
        /// <param name="personajes"></param>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public static string BuscarPersonaje(List<Personaje> personajes, string nombre)
        {
            string mensaje = String.Empty;
            
            for(int i=0;i<personajes.Count;i++)
            {
                if (String.Equals(personajes[i].nombre,nombre,StringComparison.OrdinalIgnoreCase))
                {
                    mensaje = personajes[i].ToString();
                    break;
                }
                else
                    mensaje = "No se ha encontrado ningún personaje con ese nombre";
            }
            return mensaje;

        }


        /// <summary>
        /// Constructor donde se inicializa el campo nombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="listaHabilidades"></param>
        public Personaje(string nombre, List<Marvel.EHabilidades> listaHabilidades):this()
        {
            this.nombre = nombre;
            this.listaHabilidades = listaHabilidades;
        }

        /// <summary>
        /// Propiedad que despliega las habilidades de un Personaje
        /// </summary>
        string ListaHabilidades
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (Marvel.EHabilidades hab in listaHabilidades)
                {
                    sb.AppendLine($"{hab}");
                }
                return sb.ToString();
            }
        }

        /// <summary>
        /// Propiedad abstracta que será sobreescrita en las clases villano y avenger
        /// </summary>
        protected abstract string Nombre
        {
            get;
        }

        /// <summary>
        /// Sobrecarga de operador que verifica que 2 objetos seán el mismo para retornar true, caso contrario retornará false.
        /// </summary>
        /// <param name="listaPersonaje"></param>
        /// <param name="personaje"></param>
        /// <returns></returns>
        public static bool operator ==(List<Personaje> listaPersonaje,Personaje personaje)
        {
            foreach (Personaje p in listaPersonaje)
            {
                if (personaje.GetType() == p.GetType() && p.nombre == personaje.nombre)
                    return true;
            }
            return false;
        }


        /// <summary>
        /// Sobrecarga de operador que retornará negado la sobrecarga ==
        /// </summary>
        /// <param name="listaPersonaje"></param>
        /// <param name="personaje"></param>
        /// <returns></returns>
        public static bool operator !=(List<Personaje> listaPersonaje, Personaje personaje)
        {
            return !(listaPersonaje == personaje);
        }

        /// <summary>
        /// Sobrecarga de operador que agregará un personaje a la lista en el caso de que este no exista dentro de la misma.
        /// </summary>
        /// <param name="listaPersonajes"></param>
        /// <param name="personaje"></param>
        /// <returns></returns>
        public static List<Personaje> operator + (List<Personaje> listaPersonajes,Personaje personaje)
        {
            foreach (Personaje p in listaPersonajes)
            {
                if(personaje.nombre != p.nombre)
                {
                    listaPersonajes.Add(personaje);
                }
            }

            return listaPersonajes;
        }

        /// <summary>
        /// Sobreescritura del método tostring que agrega el nombre y las habilidades de un personaje.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Nombre}");
            sb.AppendLine("Habilidades: \n"+ this.ListaHabilidades);

            return sb.ToString();
        }
    }
}
