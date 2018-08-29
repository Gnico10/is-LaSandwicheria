using La_Sandwicheria.Datos;
using La_Sandwicheria.Datos.Base_de_Datos;
using La_Sandwicheria.Interfaces;
using La_Sandwicheria.Modelo.Dominio;
using La_Sandwicheria.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Presentadores
{
   

    public class PresentadorNuevaVenta
    {
        private readonly INuevaVenta _vista;
        public Cajero CajeroSesionAct { get; set; }
        public Turno TurnoAct { get; set; }
        public Venta VentaActual { get; }

        public PresentadorNuevaVenta(Cajero cajero, Turno turno,INuevaVenta vista)
        {
            CajeroSesionAct = cajero;
            TurnoAct = turno;
            VentaActual = CajeroSesionAct.InicarVenta();
            _vista = vista;

            ColocarVentaAct();
        }

        internal void CargarLineasDeVenta()
        {
            _vista.CargarLineasDeVenta(VentaActual.LineasDeVenta);
        }

        internal void ColocarVentaAct()
        {
            _vista.ColocarVentaAct(VentaActual);
        }

        internal void RemoverLineaDeVenta(LineaDeVenta lineaSelec)
        {
            VentaActual.QuitarLineaDeVenta(lineaSelec);
        }
    }
}
