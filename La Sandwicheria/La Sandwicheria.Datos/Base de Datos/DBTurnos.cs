using La_Sandwicheria.Modelo.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Datos.Base_de_Datos
{
    public class DBTurnos
    {
        public static List<Turno> Turnos = new List<Turno>();

        public static void GuardarTurno(Turno turno)
        {
            Turnos.Add(turno);
        }
    }
}
