using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Modelo
{
    public class Venta
    {
        public int Id { get; set; }
        public DateTime FechaDeCreación { get; set; }
        public List<LineaDeVenta> LineadDeVenta { get; set; }
    }
}
