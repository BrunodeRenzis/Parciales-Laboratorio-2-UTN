using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        Guid codigo;
        string descripcion;
        double precio;
        int stock;
        protected Producto(string descripcion, double precio, int stock)
        {
            this.codigo = Guid.NewGuid();
            this.descripcion = descripcion;
            this.precio = precio;
            this.stock = stock;
        }

        public static explicit operator Guid (Producto p)
        {
            return p.codigo;
        }

        public int Stock
        {
            get {return this.stock;}
            set {if(value>=0)this.stock=value;}
        }

        public double Precio
        {
            get { return this.precio; }
        }

        public string Descripcion
        {
            get { return this.descripcion; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Producto: {Descripcion}");
            sb.AppendLine($"Código: {codigo}");
            sb.AppendLine($"Precio: {Precio}");
            sb.AppendLine($"Stock: {Stock}");
            return sb.ToString();
        }

    }
}
