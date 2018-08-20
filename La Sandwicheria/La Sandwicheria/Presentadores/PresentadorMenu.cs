using La_Sandwicheria.Modelo.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Presentadores
{
    public class PresentadorMenu
    {
        public Cajero CajeroSesionAct { get;}
        public Turno TurnoAct { get; }

        public PresentadorMenu(Cajero cajeroAct)
        {
            CajeroSesionAct = cajeroAct;
            TurnoAct = new Turno(CajeroSesionAct);
        }


        public void CerrarTurno()
        {

        }


    }
}
