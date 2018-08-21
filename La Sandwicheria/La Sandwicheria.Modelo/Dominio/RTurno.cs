using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Modelo.Dominio
{
    public class RTurno
    {
        public List<Turno> Turnos = new List<Turno>();

        public void AgregarTurno(Turno turno)
        {
            Turnos.Add(turno);
        }
    }
}
