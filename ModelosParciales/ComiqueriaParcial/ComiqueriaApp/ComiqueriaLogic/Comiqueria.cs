using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        List<Producto> productos;
        List<Venta> ventas;
        public Comiqueria()
        {
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();
        }
        public Producto this[Guid codigo]
        {
            get
            {
                foreach (Producto prod in this.productos)
                {
                    if ((Guid)prod==codigo)
                    {
                        return prod;
                    }
                }

                return null;
            }
        }

        public static bool operator ==(Comiqueria comiqueria, Producto producto)
        {
            foreach (Producto prod in comiqueria.productos)
            {
                if (prod.Descripcion == producto.Descripcion)
                    return true;

            }
            return false;
        }

        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            return !(comiqueria == producto);
        }

        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {
            foreach (Producto prod in comiqueria.productos)
            {
                if (prod.Descripcion != producto.Descripcion)
                    comiqueria.productos.Add(producto);
            }
            return comiqueria;
        }

        public Dictionary<Guid, string> ListarProductos()
        {
            Dictionary<Guid, string> lista = new Dictionary<Guid, string>();

            foreach (Producto producto in productos)
            {
                lista.Add((Guid)producto, producto.Descripcion);
            }

            return lista;
        }

        public string ListarVentas()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Venta unaVenta in ventas)
            {
                sb.AppendLine(unaVenta.ObtenerDescripcionBreve());
            }

            return sb.ToString();
        }

        public void Vender(Producto producto)
        {
            Vender(producto, 1);
        }

        public void Vender(Producto producto, int cantidad)
        {
            this.ventas.Add(new Venta(producto,cantidad));
        }
    }
}
