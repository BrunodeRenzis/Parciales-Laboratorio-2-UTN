using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public sealed class Venta
    {
        DateTime fecha;
        static int porcentajeIva;
        double precioFinal;
        Producto producto;

        static Venta()
        {
            porcentajeIva = 21;
        }

        internal Venta(Producto producto,int cantidad)
        {
            this.producto = producto;
            Vender(cantidad);
            
        }

        void Vender(int cantidad)
        {
            this.producto.Stock -= cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = CalcularPrecioFinal(this.producto.Precio,cantidad);
        }

        internal DateTime Fecha
        {
            get { return this.fecha; }
        }

        public static double CalcularPrecioFinal(double precioUnidad,int cantidad)
        {
            return precioUnidad * cantidad * porcentajeIva;
        }

        public string ObtenerDescripcionBreve()
        {
            return $"{this.fecha}-{producto.Descripcion}-{this.precioFinal}";
        }
    }
}
