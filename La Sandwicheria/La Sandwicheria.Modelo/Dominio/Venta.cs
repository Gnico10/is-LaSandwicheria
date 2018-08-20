using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Modelo.Dominio
{
    public class Venta
    {
        public int Id { get; set; }
        public double Total { get; set; }
        public DateTime FechaDeCreación { get; set; }
        public List<LineaDeVenta> LineasDeVenta { get; set; }


        public Venta() {
            FechaDeCreación = DateTime.Now;
        }
        
        public void AgregarLineaDeVenta(LineaDeVenta lineaDeVenta)
        {
            LineasDeVenta.Add(lineaDeVenta);
        }
    }
}
