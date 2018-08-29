using La_Sandwicheria.Modelo.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Modelo.Dominio
{
    public class Cajero : Persona
    {

        public int Id { get; set; }
        public int Legajo { get; set; }
        public double Sueldo { get; set; }

        public Cajero(string nombreyApe, long cuil, int legajo, double sueldo) : base(nombreyApe, cuil)
        {
            Legajo = legajo;
            Sueldo = sueldo;
        }

        public Venta InicarVenta() {
            var VentaActual = new Venta(this);
            return VentaActual;
        }

    }
}
