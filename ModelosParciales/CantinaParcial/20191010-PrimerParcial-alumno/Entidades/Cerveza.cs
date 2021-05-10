using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza:Botella
    {
        const double MEDIDA = 330;
        Tipo tipo;
        public Cerveza(int capacidadML, int contenidoML, string marca):base(capacidadML,contenidoML,marca)
        {
            this.tipo = Tipo.Vidrio;
        }

        public Cerveza(int capacidadML, int contenidoML, string marca,Tipo tipo) : this(capacidadML,contenidoML,marca)
        {
            this.tipo = tipo;
        }

        public override float ServirMedida()
        {
            float descuento;
            float medida = (float)(Cerveza.MEDIDA * 0.8f);
            if (medida <= base.Contenido)
            {
                descuento = medida;
            }
            else
            {
                descuento=base.Contenido;
            }

            base.Contenido -= descuento;

            return descuento;
        }

        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }


        public override string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.GenerarInforme());
            sb.Append($"Tipo Botella: {tipo}");
            sb.Append("Medida: " +MEDIDA);
            return sb.ToString();
        }
    }
}
