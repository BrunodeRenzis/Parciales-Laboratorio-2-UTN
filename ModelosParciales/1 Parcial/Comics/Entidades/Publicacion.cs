using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Publicacion
    {
        protected float importe;
        protected string nombre;
        protected int stock;

        public Publicacion(string nombre, int stock, float importe):this(nombre,stock)
        {
            this.importe = importe;
        }

        public Publicacion(string nombre, int stock):this(nombre)
        {
            this.stock = stock;
        }

        public Publicacion(string nombre)
        {
            this.nombre = nombre;
        }

        protected abstract bool EsColor
        {
            get;
        }

        public virtual bool HayStock
        {
            get { if (this.stock > 0 && this.importe>0) return true; return false; }
        }

        public float Importe
        {
            get { return this.importe; }
        }

        public int Stock
        {
            get { return this.stock; }
            set { if(HayStock) this.stock = value; }
        }

        public string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Nombre: {this.nombre} \n");
            sb.AppendFormat("Stock: ", Stock);
            sb.AppendLine($"Color: {EsColor}");
            sb.AppendLine($"Valor: {Importe}");
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.nombre;
        }
    }
}
