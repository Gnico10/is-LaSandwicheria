using La_Sandwicheria.Datos.Base_de_Datos;
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
        public RTurno RegistroTurnos { get; set; }

        public PresentadorMenu(Cajero cajeroAct)
        {
            //Almacen
            DBAlmacen.IntanciarRubrosProductos();
            //------------------------------------------------


            CajeroSesionAct = cajeroAct;
            TurnoAct = new Turno(CajeroSesionAct);
            RegistroTurnos = new RTurno();
        }


        public void CerrarTurno()
        {
            
            TurnoAct.CerrarTurno();
            RegistroTurnos.AgregarTurno(TurnoAct);

            //Guardar en DB
            DBTurnos.GuardarTurno(TurnoAct);
            //-------------
        }


    }
}
