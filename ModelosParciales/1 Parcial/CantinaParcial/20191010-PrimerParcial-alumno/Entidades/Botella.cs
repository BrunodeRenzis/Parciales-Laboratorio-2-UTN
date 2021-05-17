using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Botella
    {
        protected float capacidadML;
        protected float contenidoML;
        protected string marca;

        public Botella(float capacidadML, float contenidoML, string marca)
        {
            if(CapacidadLitros<Contenido)
            {
                this.Contenido = capacidadML;
            }
            this.contenidoML = contenidoML;
            this.capacidadML = capacidadML;
            this.marca = marca;
        }

        public enum Tipo
        {
            Vidrio,Plastico
        }
        public float CapacidadLitros
        {
            get => capacidadML/1000;
        }

        public float PorcentajeContenido
        {
            get { return ((this.contenidoML * 100) / this.capacidadML); }
        }

        public  float Contenido
        {
            get { return this.contenidoML; }
            set { this.contenidoML = value; }
        }

        public virtual string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Capacidad: " + this.CapacidadLitros);
            sb.Append("Contenido: " + this.PorcentajeContenido);
            sb.Append("Marca: " + this.marca);

            return sb.ToString();
        }

        public abstract float ServirMedida();

        public override string ToString()
        {

            return GenerarInforme();
        }
    }
}
