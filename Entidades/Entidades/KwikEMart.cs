using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class KwikEMart
    {
        public static List<Producto> listaProductos;
        public static List<Cliente> listaClientes;
        public static List<Empleado> listaEmpleados;
        public static List<Venta> listaVentas;
        public static Dictionary<string, string> loginEmpleado;
        public static Empleado empleadoLogueado;

        static KwikEMart()
        {
            listaProductos = new List<Producto>();
            listaClientes = new List<Cliente>();
            listaEmpleados = new List<Empleado>();
            listaVentas = new List<Venta>();
            loginEmpleado = new Dictionary<string, string>();
        }

        
        public static void IngresarProductos(string descripcion, double precio, int stock)
        {
            listaProductos.Add(new Producto(descripcion,precio,stock));
        }

        public static void HarcodearUsuario()
        {
            loginEmpleado.Add("bruno2020", "brunopass");
            loginEmpleado.Add("alan2020", "alanpass");
        }
        static void IngresarCliente(string nombre,string apellido,int dni)
        {
            listaClientes.Add(new Cliente(nombre, apellido, dni));
        }

        static List<Venta> ListadoVentas(int idEmpleado)
        {
            List<Venta> auxVentas = new List<Venta>();
            
            return auxVentas;
        }
            

            public static int StockTotal()
        {
            int acumulador = 0;

            for (int i = 0; i < listaProductos.Count; i++)
            {
                acumulador += listaProductos[i].Stock;
            }

            return acumulador;
        }

        public static List<Producto> StockMennosDe10Unidades()
        {
            List<Producto> auxProductos = new List<Producto>();

            for (int i = 0; i < listaProductos.Count; i++)
            {
                if (listaProductos[i].Stock < 10)
                {
                    auxProductos.Add(listaProductos[i]);
                }
            }

            return auxProductos;
        }

       

        public static int StockAutomatico()
        {
            int retorno;
            Random stock = new Random();
            
            retorno = stock.Next(1, 500);
            
            return retorno;
        }
        public static double PrecioAutomatico()
        {
            double retorno;
            Random precio = new Random();

            retorno = precio.Next(100, 500);

            return retorno;
        }
        public static void HardcodeoListados()
        {
            string[] nombreEmpleados = new string[2] { "Bruno", "Alan" };
            string[] apellidoEmpleados = new string[2] { "de Renzis", "Scheveloff" };
            string[] listaUsuarios = new string[2] { "bruno2020", "alan2020" };
            Dictionary<string, string>[] usuarioEmpleados = new Dictionary<string,string>[2];
            
            int[] idEmpleados = new int[2] { 1, 2 };
            int[] dniEmpleados = new int[2] { 23323232, 34545454 };
            string[] descripcion = new string[30] { "Tarta de luna", "Billete de lotería", "Raspado fresa", "Raspado Café", "Raspado Uva", "Chicle El granjero Joe", "Duff",
            "Duff free alcohol", "Lápida","testamento", "Donas", "Salchichas de alga", "Cereal Krusty'O", "Helado Café", "Colorante Azul Para Cabello", "Cigarrillos Laramie", "Azucar del granjero homero",
            "Buzz Cola", "Petardos Ilegales", "Condones", "Patatas fritas que provocan diarrea's", "Tarjeta San Valentín Monos", "Leche expirada en 1961", "Jamón Caido al piso", "6 kilos de langostino", "Dedos de manteca", "Salchichas llenas de grasa", "Chupelupe",
            "Tocino","Armas" };

            string[] nombreClientes = new string[10] {"Homero","Marge","Ned","Krusty","Fat","Bart", "Milhouse","Abe","Nelson","Jimbo"}; 
            string[] apellidoClientes = new string[10] {"Simpson","Bouvier","Flanders","The Clown","Tony","Simpson", "Mussolini Vanhouten","Simpson","Ruffino","Jones"};
            int[] dniClientes = new int[10] { 23323232, 34545454,23232323,42424245,35363635,23232121,24424387,17564212,25744321,32653435};

            for (int i = 0; i < 2; i++)
            {
                listaEmpleados.Add(new Empleado(nombreEmpleados[i], apellidoEmpleados[i],dniEmpleados[i],listaUsuarios[i], idEmpleados[i]));
            }

            for (int i=0;i<10;i++)
            {
                listaClientes.Add(new Cliente(nombreClientes[i], apellidoClientes[i], dniClientes[i]));
            }

            foreach (var item in descripcion)
            {
                listaProductos.Add(new Producto(item,PrecioAutomatico(),StockAutomatico()));
            }

        }
    }


}
