using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor
    {
        string nombre;
        List<Publicacion> ventas;

        Vendedor()
        {
            ventas = new List<Publicacion>();
        }

        public Vendedor(string nombre):this()
        {
            this.nombre = nombre;
        }
        
        public static bool operator +(Vendedor v,Publicacion p)
        {
            if(p!=null)
            {
                if(p.HayStock)
                {
                    v.ventas.Add(p);
                    p.Stock--;
                    return true;
                }
            }
            return false;
        }

        public static string InformeDeVentas(Vendedor v)
        {
            StringBuilder sb = new StringBuilder();
            float ganancia=0;
            sb.AppendLine($"Nombre vendedor: {v.nombre}");
            if(v.ventas!=null)
            {
                foreach (Publicacion item in v.ventas)
                {
                    sb.AppendLine($"Publicación: {item}");
                    ganancia += item.Importe;
                }
                    sb.AppendLine($"Ganancia total: {ganancia:C2}");
            }
                return sb.ToString();
        }
    }
}
