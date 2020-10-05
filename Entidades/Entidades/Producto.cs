using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
#pragma warning disable CS0660
#pragma warning disable CS0661
    public class Producto
    {
        string descripcion;
        int idProducto;
        double precio;
        int stock;
        static int idAutomatico = 0;
        private Producto()
        {
            this.descripcion = "sin descripcion";
            this.precio = -1;
            this.stock = -1;
            idAutomatico++;
            this.idProducto = idAutomatico;
        }

        public Producto(string descripcion, double precio, int stock) : this()
        {
            this.descripcion = descripcion;
            this.precio = precio;
            this.stock = stock;
        }

        public static bool operator +(List<Producto> listaProductos, Producto auxProducto)
        {
            int cantidad = 0;
            for (int i = 0; i < listaProductos.Count; i++)
            {
                if (listaProductos[i].idProducto == auxProducto.idProducto)
                {
                    auxProducto.stock = auxProducto.Stock - cantidad;
                    return true;
                }
            }

            return false;
        }

        public static bool operator ==(List<Producto> listaProductos, Producto auxProducto)
        {
            for (int i = 0; i < listaProductos.Count; i++)
            {
                if (listaProductos[i].descripcion == auxProducto.descripcion)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(List<Producto> listaProductos, Producto auxProducto)
        {
            return !(listaProductos == auxProducto);
        }


        public int Stock
        {
            get { return this.stock; }
        }

        public int IdProducto
        {
            get { return this.idProducto; }
        }

        public string Descripcion
        {
            get { return this.descripcion; }
        }

        public double Precio
        {
            get { return this.precio; }
        }

        public virtual string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Descripcion: {this.descripcion}");
            stringBuilder.AppendLine($"ID Producto: {this.idProducto.ToString()}");
            stringBuilder.AppendLine($"Stock: {this.stock.ToString()}");
            stringBuilder.AppendLine(String.Format("Precio: ${0: #,###.00}", this.precio));

            return stringBuilder.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
