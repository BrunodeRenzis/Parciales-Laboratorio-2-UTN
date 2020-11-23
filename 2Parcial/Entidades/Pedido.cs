using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Archivos;
namespace Entidades
{
    public static class Pedido
    {
        static Queue<Parrilla> pedidoTomado;
        static Queue<Parrilla> pedidoPreparado;

        static Pedido()
        {
            PedidoPreparado = new Queue<Parrilla>();
            PedidoTomado = new Queue<Parrilla>();
        }

        public static Queue<Parrilla> PedidoTomado { get => pedidoTomado; set => pedidoTomado = value; }
        public static Queue<Parrilla> PedidoPreparado { get => pedidoPreparado; set => pedidoPreparado = value; }

        public static void AgregarPedidos()
        {
            List<Parrilla> pedidos = Leer();


            foreach (Parrilla pedido in pedidos)
            {
                pedidoTomado.Enqueue(pedido);
            }


        }
        public static List<Parrilla> Leer()
        {
            List<Parrilla> datosPedido = new List<Parrilla>();
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "pedidos.xml");
            Xml<List<Parrilla>> listaPedidos = new Xml<List<Parrilla>>();

            listaPedidos.Leer(path, out datosPedido);

            return datosPedido;

        }

        public static bool PedidosIniciales()
        {
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "pedidos.xml");
            Xml<List<Parrilla>> auxPedidos = new Xml<List<Parrilla>>();

            List<Parrilla> pedidos = new List<Parrilla>();
            pedidos.Add(new Parrilla("Leandro N Alem sur 258", Parrilla.EParrilla.Molleja));
            Thread.Sleep(2000);
            pedidos.Add(new Parrilla(Parrilla.EParrilla.Riñon));
            Thread.Sleep(2000);
            pedidos.Add(new Parrilla(Parrilla.EParrilla.Provoleta));
            Thread.Sleep(2000);
            pedidos.Add(new Parrilla("Alcorta 853", Parrilla.EParrilla.Chinchulin));
            Thread.Sleep(2000);
            pedidos.Add(new Parrilla("Italia 810", Parrilla.EParrilla.Entraña));
            Thread.Sleep(2000);
            pedidos.Add(new Parrilla("Juncal 820", Parrilla.EParrilla.Asado));
            Thread.Sleep(2000);
            pedidos.Add(new Parrilla("Av.Espora 2051", Parrilla.EParrilla.Vacio));
            Thread.Sleep(2000);
            

            return auxPedidos.Guardar(path, pedidos);
        }

    }
}
