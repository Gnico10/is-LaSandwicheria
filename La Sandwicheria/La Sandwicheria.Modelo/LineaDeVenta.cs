﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Modelo
{
    public class LineaDeVenta
    {
        public int Id { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }


        public LineaDeVenta(Producto producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
        }

    }
}
