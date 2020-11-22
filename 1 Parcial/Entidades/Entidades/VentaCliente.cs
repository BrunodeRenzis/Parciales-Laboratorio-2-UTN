using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VentaCliente: Venta
    {
        
        public VentaCliente(Empleado vendedor,Cliente comprador,double montoTotal):base(vendedor,comprador,montoTotal)
        {

        }
    }
}
