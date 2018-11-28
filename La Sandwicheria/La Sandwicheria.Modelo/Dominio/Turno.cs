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
        public DateTime FechaYHoraInicio { get; set; }
        public DateTime FechaYHoraCierre { get; set; }
        public double Rendicion { get; set; }
        public List<Pedido> VentasDelTurno = new List<Pedido>();
        public Estados _Estado { get; set; }

        public Turno(Cajero cajero, Estados estado = Estados.Abierto)
        {
            FechaYHoraInicio = DateTime.Now;
            Cajero = cajero;

            _Estado = estado;

        }

        public void AgregarVenta(Pedido venta)
        {
            VentasDelTurno.Add(venta);
            ActualizarRendicion();
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
            FechaYHoraCierre = DateTime.Now;
            _Estado = Estados.Cerrado;
        }
    }
}
