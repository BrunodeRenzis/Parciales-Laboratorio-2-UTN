﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Figura:Producto
    {
        double altura;

        public Figura(string descripcion,int stock, double precio, double altura):base(descripcion,precio,stock)
        {
            this.altura = altura;
        }
        public Figura(int stock, double precio,double altura):this($"Figura {altura} cm",stock, precio, altura)
        {
            
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Altura: {altura}");
            return sb.ToString();
        }
    }
}
