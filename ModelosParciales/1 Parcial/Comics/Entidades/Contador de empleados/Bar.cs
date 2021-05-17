using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador_de_empleados
{
    public class Bar
    {
        List<Empleado> empleados;
        List<Gente> gente;
        static Bar singleton;

        public Bar()
        {
            this.empleados = new List<Empleado>();
            this.gente = new List<Gente>();
        }

        public static bool operator +(Bar bar,Empleado empleado)
        {

        }

        public static bool operator +(Bar bar, Gente gente)
        {

        }

        public static Bar GetBar()
        {
            if (Bar.singleton is null)
            {
                singleton = new Bar();
            }
            return Bar.singleton;
        }

    }
}
