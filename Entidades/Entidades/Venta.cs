using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Venta
    {
        protected Cliente comprador;
        protected double montoTotal;
        protected List<Venta> listaVenta;
        protected Empleado empleado;
        protected int numeroTicket;
        protected static int ticket=1;

        public Venta()
        {
            listaVenta = new List<Venta>();
            ticket++;
        }

        public Venta(Empleado vendedor, Cliente comprador, double montoTotal): this()
        {
            this.comprador = comprador;
            this.empleado = vendedor;
            this.montoTotal = montoTotal;
            this.numeroTicket = ticket;
        }

        public List <Venta> ListaVenta
        {
            get { return this.listaVenta; }
        }


    }
}
