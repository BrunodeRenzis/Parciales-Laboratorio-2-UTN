using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoNoPerecedero:Producto
    {
        public ProductoNoPerecedero(string descripcion,double precio,int stock,Producto.tipoProductos tipo):base(descripcion,precio,stock,tipo)
        {
            
        }
    }
}
