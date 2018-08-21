using La_Sandwicheria.Modelo.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Datos.Almacen
{
    public static class Almacen
    {
        public static List<Producto> Productos = new List<Producto>();
        public static List<Rubro> Rubros = new List<Rubro>();

        public static void Almacenar(List<Producto> listaProductos, List<Rubro> listaRubros)
        {
            Productos = listaProductos;
            Rubros = listaRubros;
        }
    }
}
