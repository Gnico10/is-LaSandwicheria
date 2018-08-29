using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Modelo.Dominio
{
    
    public class PuntoDeVenta
    {
        public int NroPuntoDeVenta { get; set; }
        public string NombreDelPunto { get; set; }

        public PuntoDeVenta(int nroPuntoDeVenta, string nombrePto)
        {
            NroPuntoDeVenta = nroPuntoDeVenta;
            NombreDelPunto = nombrePto;
        }

    }
}
