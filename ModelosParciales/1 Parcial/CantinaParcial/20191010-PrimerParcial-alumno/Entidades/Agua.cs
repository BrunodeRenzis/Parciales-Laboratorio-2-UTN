using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua : Botella
    {
        const float MEDIDA = 400;
        public Agua(int capacidadML,int contenidoML,string marca):base(capacidadML,contenidoML,marca)
        {

        }
        
        public override float ServirMedida()
        {
            if (MEDIDA <= Contenido)
            {
                Contenido-=MEDIDA;
            }
            else if(MEDIDA>=Contenido)
            {
                Contenido -= Contenido;
            }

            return Contenido;
        }

        public float ServirMedida(int cantidad)
        {
            if (MEDIDA != cantidad)
            {
                Contenido -= MEDIDA;
                if (Contenido >= 0)
                {
                    return Contenido;
                }
            }
            return 0;
        }

        public override string GenerarInforme()
        {
            return base.GenerarInforme()+" Medida: "+MEDIDA.ToString();
        }
    }
}
