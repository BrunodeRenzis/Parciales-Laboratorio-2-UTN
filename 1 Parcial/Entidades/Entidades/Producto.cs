using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public abstract class Producto
    {
        protected string descripcion;
        protected int idProducto;
        protected double precio;
        protected int stock;
        protected tipoProductos tipoProducto;
        protected static int idAutomatico = 0;
        private Producto()
        {
            this.descripcion = "sin descripcion";
            this.precio = -1;
            this.stock = -1;
            idAutomatico++;
            this.idProducto = idAutomatico;
        }

        public enum tipoProductos
        {
            perecedero,
            noPerecedero
        }

        public Producto(string descripcion, double precio, int stock,tipoProductos tipoProducto) : this()
        {
            this.descripcion = descripcion;
            this.precio = precio;
            this.stock = stock;
            this.tipoProducto = tipoProducto;
        }

        public static bool operator +(List<Producto> listaProductos, Producto auxProducto)
        {
            bool retorno = false;

            if (listaProductos != auxProducto)
            {
                listaProductos.Add(auxProducto);
                retorno = true;

            }
            else
            {
                for (int i = 0; i < listaProductos.Count; i++)
                {
                    if (listaProductos[i].idProducto == auxProducto.idProducto)
                    {
                        listaProductos[i].stock = auxProducto.Stock;

                    }
                }
            }

            return retorno;
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
            set { this.stock = value; }
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

        public tipoProductos TipoProducto
        {
            get { return this.tipoProducto; }
        }

        public virtual string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Descripcion: {this.descripcion}");
            stringBuilder.AppendLine($"ID Producto: {this.idProducto}");
            stringBuilder.AppendLine($"Stock: {this.stock}");
            stringBuilder.AppendLine(String.Format("Precio: ${0: #,###.00}", this.precio));

            return stringBuilder.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
