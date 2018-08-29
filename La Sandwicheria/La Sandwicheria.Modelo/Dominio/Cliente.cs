using La_Sandwicheria.Modelo.Configuraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Modelo.Dominio
{
    public class Cliente : Persona
    {
        public CondicionTributaria CondTributaria { get; set; }
        public TiposDocumentos DocTipo { get; set; }

        public Cliente(string nombreyApellido, long cuil, CondicionTributaria condTributaria = CondicionTributaria.ConsumidorFinal) 
            : base(nombreyApellido, cuil)
        {
            CondTributaria = condTributaria;
            DocTipo = TiposDocumentos.CUIL;
        }


    }
}
