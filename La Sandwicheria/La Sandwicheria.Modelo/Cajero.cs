using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Modelo
{
    public class Cajero
    {

        public int Id { get; set; }
        public string NombreyApe { get; set;}
        public int Legajo { get; set; }
        public int sueldo { get; set; }
        public Turno TurnoActual { get; set; }
        public Venta VentaActual { get; set; }

        //Asociacion de uno a muchos
        public virtual List<Turno> TurnosTermiandos { get; set; }
        public virtual List<Venta> VentasRealizadas { get; set; }

        public Cajero(string nombreyApe, int legajo, int sueldo)
        {
            NombreyApe = nombreyApe;
            Legajo = legajo;
            this.sueldo = sueldo;
        }

        public void IniciarNuevoTurno() {
            TurnoActual = new Turno();
        }

        public double TerminarTurno() {

            TurnoActual.CerrarTurno();
            TurnosTermiandos.Add(TurnoActual);

            return TurnoActual.Rendicion;
        }

        public void InicarVenta() {
            VentaActual = new Venta();
        }

        public void TerminarVenta() {
            TurnoActual.ActualizarRendicion(VentaActual.Total);
            //TODO: Facturacion
        }
    }
}
