using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
namespace Entidades
{
    public class Parrilla
    {

        int nroPedido;
        string direccion;
        EParrilla pedido;
        bool delivery;

        /// <summary>
        /// Constructor pedido para retirar levantando de la base de datos.
        /// </summary>
        /// <param name="pedido"></param>
        public Parrilla(EParrilla pedido)
        {
            this.Pedido = pedido;
            this.Delivery = false;
        }

        /// <summary>
        /// Constructor Pedido para retirar instanciando el objeto.
        /// </summary>
        /// <param name="nroPedido"></param>
        /// <param name="pedido"></param>
        public Parrilla(int nroPedido, EParrilla pedido):this(pedido)
        {
            this.NroPedido = nroPedido;
            this.Delivery = false;
        }

        /// <summary>
        /// Constructor pedido para delivery levantando de la base de datos.
        /// </summary>
        /// <param name="direccion"></param>
        /// <param name="pedido"></param>
        public Parrilla(string direccion, EParrilla pedido):this(pedido)
        {
            this.direccion = direccion;
            this.Delivery = true;
        }

        /// <summary>
        /// Constructor pedido para delivery instanciando.
        /// </summary>
        /// <param name="nroPedido"></param>
        /// <param name="direccion"></param>
        /// <param name="pedido"></param>
        public Parrilla(int nroPedido,string direccion, EParrilla pedido):this(nroPedido,pedido)
        {
            this.Direccion = direccion;
            this.Delivery = true;
        }

        

        public int NroPedido { get => nroPedido; set => nroPedido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public EParrilla Pedido { get => pedido; set => pedido = value; }
        public bool Delivery { get => delivery; set => delivery = value; }

        public enum EParrilla
        {
            Asado,
            Chinchulin,
            Entraña,
            Molleja,
            Provoleta,
            Riñon,
            Vacio
        }

        public enum EEstado
        {
            EnPreparacion,
            EnViaje,
            Entregado
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Pedido Nro.: {this.NroPedido}");
            sb.AppendLine($"Pedido {this.Pedido.ToString()}");
            sb.AppendLine($"Direccion: {this.Direccion}");

            return sb.ToString();
        }

        /// <summary>
        /// Imprime ticket para los pedidos de delivery.
        /// </summary>
        /// <param name="pedido"></param>
        /// <returns></returns>
        public static bool Ticket(Parrilla pedido)
        {
            bool retorno = false;
            string path;

            if (pedido != null)
            {
                path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, pedido.nroPedido.ToString());

                Texto texto = new Texto();

                texto.Guardar(path, pedido.ToString());
                retorno = true;
            }

            return retorno;
        }
    }
}
