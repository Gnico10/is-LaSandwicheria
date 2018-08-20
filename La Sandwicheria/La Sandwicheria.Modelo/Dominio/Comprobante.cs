using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Modelo.Dominio
{
    class Comprobante
    {

        public int Id { get; set; }
        public string TipoComprobante { get; set; }
        public Venta venta { get; set; }

        public Comprobante(string tipoComprobante, Venta venta)
        {
            TipoComprobante = tipoComprobante;
            this.venta = venta;
        }
    }
}
