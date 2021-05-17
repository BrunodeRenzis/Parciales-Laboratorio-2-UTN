using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Marvel
    {
        public static List<Personaje> listaPersonajes;

        /// <summary>
        /// Inicialización de la listaPersonajes en el constructor estático.
        /// </summary>
        static Marvel()
        {
            listaPersonajes = new List<Personaje>();
        }
        public enum EHabilidades
        {
            Volar,
            SuperFuerza,
            Resistencia,
            Rayos,
            Energia,
            InteligenciaSuperior,
            Sigilio,
            Astucia
        }

        public enum EEquipamiento
        {
            Armadura,
            Escudo,
            Martillo,
            Arco,
            Transformacion,
            ArtesMarciales
        }

        /// <summary>
        /// Propiedad estática que agrega un personaje a la lista en el caso de no existir.
        /// </summary>
        public static Personaje Personaje
        {
            set
            {
                if (listaPersonajes != value)
                {
                    listaPersonajes.Add(value);
                }
            }
        }

        /// <summary>
        /// Método estático que mostrará la información de los heroes y villanos del programa dependiendo su tipo.
        /// </summary>
        /// <returns></returns>
        public static string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Personaje personaje in listaPersonajes)
            {
                if(personaje.GetType() == typeof(Enemigo))
                {
                    sb.AppendLine("****** ENEMIGO ******");
                    sb.AppendLine(personaje.ToString());
                }

                if(personaje.GetType() == typeof(Avenger))
                {
                    sb.AppendLine("****** AVENGER ******");
                    sb.AppendLine(personaje.ToString());
                }
            }

            return sb.ToString();
        }
    }
}
