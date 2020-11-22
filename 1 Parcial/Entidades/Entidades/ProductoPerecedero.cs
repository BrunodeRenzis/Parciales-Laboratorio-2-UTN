using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoPerecedero:Producto
    {
        string fechaVto;
        public ProductoPerecedero(string descripcion,double precio,int stock,Producto.tipoProductos tipo,string fechaVencimiento):base(descripcion,precio,stock,tipo)
        {
            this.fechaVto = fechaVencimiento;
        }
    }
}
