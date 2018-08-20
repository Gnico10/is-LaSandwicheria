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

        public PresentadorNuevaVenta(Cajero cajero,INuevaVenta vista)
        {
            CajeroSesionAct = cajero;
            _vista = vista;
        }


    }
}
