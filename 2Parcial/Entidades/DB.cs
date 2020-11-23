using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Archivos;
using Excepciones;
namespace Entidades
{
    public static class DB
    {
        private static SqlConnection conexion;
        private static SqlCommand comando;

        static DB()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source = DESKTOP-PEHMTAT\\SQLEXPRESS; Initial Catalog=2Parcial; Integrated Security=True;";
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        public static bool VerificarConexion()
        {

            string connetionString = String.Empty;
            SqlConnection cnn;
            connetionString = "Data Source=DESKTOP-PEHMTAT\\SQLEXPRESS;Initial Catalog=2Parcial; Integrated Security=True";

            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                cnn.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }


        #region Metodos

        /// <summary>
        /// Ejecuta ExecuteNonQuery() en una conexion SQL
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>True si se ejecuto, false caso contrario</returns>
        public static bool EjecutarNonQuery(string sql)
        {
            bool ejecuto = false;
            try
            {
                comando.CommandText = sql;

                if (conexion.State != ConnectionState.Open)
                    conexion.Open();

                comando.ExecuteNonQuery();
                ejecuto = true;
            }
            catch (Exception e)
            {
                ejecuto = false;
                throw new ArchivoException("Falla al intentar trabajar sobre la base de datos", e);
            }
            finally
            {
                conexion.Close();
            }

            return ejecuto;
        }

        /// <summary>
        /// Inserta un pedido a la base de datos
        /// </summary>
        /// <param name="comidaPedida"></param>
        /// <returns>True si se guardo, false caso contrario</returns>
        public static bool InsertarPedido(Parrilla comidaPedida)
        {
            string sql = "Insert into Pedidos(idPedido, tieneDelivery, domicilio, telefono) " +
                "values(@auxTipo, @auxPedido, @auxDelivery, @auxDomicilio, @auxTelefono)";

            comando.Parameters.Clear();
            comando.Parameters.Add(new SqlParameter("@auxPedido", comidaPedida.NroPedido));
            comando.Parameters.Add(new SqlParameter("@auxDomicilio", comidaPedida.Direccion));
            comando.Parameters.Add(new SqlParameter("@auxTipo", comidaPedida.Pedido.ToString()));
            comando.Parameters.Add(new SqlParameter("@auxDelivery", comidaPedida.Delivery.ToString()));
            
            return EjecutarNonQuery(sql);
        }

        #endregion


    }
}
