using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        Cliente comprador;
        double montoTotal;
        List<Venta> listaVenta;
        Empleado empleado;
        int numeroTicket;
        static int ticket=0;

        public Venta()
        {
            listaVenta = new List<Venta>();
            ticket++;
        }

        public Venta(Empleado vendedor, Cliente comprador, double montoTotal,Empleado empleado): this()
        {
            this.comprador = comprador;
            this.empleado = empleado;
            this.montoTotal = montoTotal;
            this.numeroTicket = ticket;
        }

    }
}
