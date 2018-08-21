using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Modelo.Dominio
{
    public class Turno
    {
        

        public int Id { get; set; }
        public Cajero Cajero { get; set; }
        public DateTime FechaYHora { get; set; }
        public double Rendicion { get; set; }
        public List<Venta> VentasDelTurno = new List<Venta>();
        private Estados _Estado { get; set; }

        public Turno(Cajero cajero, Estados estado = Estados.Abierto)
        {
            FechaYHora = DateTime.Now;
            Cajero = cajero;

            _Estado = estado;

        }

        public void AgregarVenta(Venta venta)
        {
            VentasDelTurno.Add(venta);
        }

        public void ActualizarRendicion()
        {
            var rend = 0.0;
            foreach (var venta in VentasDelTurno)
            {
                rend += venta.Total;
            }

            Rendicion = rend;
        }

        public void CerrarTurno()
        {
            _Estado = Estados.Cerrado;
        }
    }
}
