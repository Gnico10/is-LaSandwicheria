using La_Sandwicheria.Modelo.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Datos.Base_de_Datos
{
    public class DBVentas
    {
        public static List<Venta> Ventas = new List<Venta>();

        public static void GuardarVenta(Venta venta)
        {
           Ventas.Add(venta);
        }

    }
}
