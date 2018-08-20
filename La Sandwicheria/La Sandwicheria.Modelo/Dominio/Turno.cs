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
        public DateTime FechaYHora { get; set; }
        public double Rendicion { get; set; }
        public Cajero Cajero { get; set; }

        private Estados _Estado { get; set; }

        public Turno(Cajero cajero, Estados estado = Estados.Abierto)
        {
            FechaYHora = DateTime.Now;
            Cajero = cajero;

            _Estado = estado;

        }

        public void ActualizarRendicion(double SubTotal)
        {
            Rendicion = Rendicion + SubTotal;
        }

        public double CerrarTurno()
        {
            _Estado = Estados.Cerrado;
            return Rendicion;
        }
    }
}
