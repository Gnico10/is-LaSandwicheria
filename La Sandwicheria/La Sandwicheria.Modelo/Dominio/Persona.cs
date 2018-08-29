using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Modelo.Dominio
{
    public class Persona
    {
        public string NombreYApe { get; set; }
        public long Cuil { get; set; }

        public Persona(string nombreyApellido, long cuil)
        {
            NombreYApe = nombreyApellido;
            Cuil = cuil;
        }
    }
}
