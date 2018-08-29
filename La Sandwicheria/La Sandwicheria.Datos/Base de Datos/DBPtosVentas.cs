using La_Sandwicheria.Modelo.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Datos.Base_de_Datos
{
    public class DBPtosVentas
    {
        public static List<PuntoDeVenta> PtosDeVenta = new List<PuntoDeVenta>();

        public static void CargarPtosDeVenta()
        {
            if (PtosDeVenta.Count == 0)
            {
                var punto1 = new PuntoDeVenta(1, "LA SANDWICHERÍA - Tucumán");
                var punto2 = new PuntoDeVenta(2, "LA SANDWICHERÍA - Salta");
                var punto3 = new PuntoDeVenta(3, "LA SANDWICHERÍA - Jujuy");

                PtosDeVenta.Add(punto1);
                PtosDeVenta.Add(punto2);
                PtosDeVenta.Add(punto3);
            }
        }
    }
}
