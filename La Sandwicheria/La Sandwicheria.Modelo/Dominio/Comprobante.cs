using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Modelo.Dominio
{
    public class Comprobante
    {
        public int Id { get; set; }
        public string TipoComprobante { get; set; }
        public Venta venta { get; set; }

        public Comprobante(Venta venta)
        {
            this.venta = venta;
        }
    }
}
