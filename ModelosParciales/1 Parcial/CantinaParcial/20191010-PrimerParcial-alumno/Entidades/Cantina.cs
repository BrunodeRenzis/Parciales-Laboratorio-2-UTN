using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cantina
    {
        List<Botella> botellas;
        int espaciosTotales;
        static Cantina singleton;

        private Cantina(int espacio)
        {
            this.espaciosTotales = espacio;
            this.botellas = new List<Botella>();
        }

        public List<Botella> Botellas
        {
            get
            {
                return this.botellas;
            }

        }

        public static Cantina GetCantina(int espacio)
        {
            if(singleton==null)
            {
                singleton = new Cantina(espacio);
            }

            else
            {
                singleton.espaciosTotales+=espacio;
            }

            return singleton;
        }

        public static bool operator +(Cantina c, Botella b)
        {
            if (c.botellas.Count < c.espaciosTotales)
            {
                c.botellas.Add(b);
                return true;
            }
            return false;
        }

    }
}
