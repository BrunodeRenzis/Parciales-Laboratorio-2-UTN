using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador_de_empleados
{
    public class Gente : Persona
    {
        public Gente(short edad):base(edad,null)
        {

        }
        public override bool Validar()
        {
            if (this.Edad >= 18)
                return true;

            return false;
        }

        protected override string Mostrar()
        {
            if (Validar())
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("GENTE:");
                sb.AppendLine(base.Mostrar());
                return sb.ToString();
            }

            else
                return "No se han validado los datos";

        }
    }
}
