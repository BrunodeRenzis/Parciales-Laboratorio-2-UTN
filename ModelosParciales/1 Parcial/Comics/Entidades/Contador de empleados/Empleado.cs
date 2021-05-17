using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador_de_empleados
{
    public class Empleado : Persona
    {
        int dni;

        public Empleado(string nombre, short edad) : base(edad, nombre)
        {
            this.dni = -1;
        }
        public Empleado(string nombre, short edad, int dni):this(nombre,edad)
        {
            this.dni = dni;
        }
        public override bool Validar()
        {
            if (this.Nombre.Length >= 2 && this.Edad >= 21)
                return true;

            return false;
        }

        public static bool operator ==(Empleado e1, Empleado e2)
        {
            if (e1.Nombre==e2.Nombre)
                return true;

            return false;
        }
        public static bool operator !=(Empleado e1, Empleado e2)
        {
            return !(e1 == e2);
        }

        protected override string Mostrar()
        {
            if (Validar())
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("EMPLEADO:");
                sb.AppendLine(base.Mostrar());
                return sb.ToString();
            }

            else
                return "No se han validado los datos";

        }
    }
}
