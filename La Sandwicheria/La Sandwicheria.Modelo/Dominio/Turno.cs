using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Modelo
{
    public class Turno
    {
        

        public int Id { get; set; }
        public DateTime FechaYHora { get; set; }
        public double Rendicion { get; set; }

        private Estados _Estado { get; set; }

        public Turno(double rendicion = 0, Estados estado = Estados.Abierto)
        {
            FechaYHora = DateTime.Now;

            Rendicion = rendicion;

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
