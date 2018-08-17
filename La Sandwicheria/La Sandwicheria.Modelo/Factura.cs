using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Modelo
{
    class Factura
    {

        public int Id { get; set; }
        public string TipoFacutura { get; set; }
        public DateTime FechaYHora { get; set; }
        public Venta venta { get; set; }

        public Factura(string tipoFacutura, Venta venta)
        {
            TipoFacutura = tipoFacutura;
            this.venta = venta;

            FechaYHora = DateTime.Now;
        }
    }
}
