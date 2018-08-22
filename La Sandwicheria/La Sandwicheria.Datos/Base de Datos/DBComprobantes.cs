using La_Sandwicheria.Modelo.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Datos.Base_de_Datos
{
    public class DBComprobantes
    {
        public static List<Comprobante> Comprobantes = new List<Comprobante>();

        public static void GuardarComprobante(Comprobante comprobante)
        {
            Comprobantes.Add(comprobante);
        }
    }
}
