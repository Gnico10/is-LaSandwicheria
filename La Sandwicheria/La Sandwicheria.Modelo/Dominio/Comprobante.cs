using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using La_Sandwicheria.Modelo.Configuraciones;

namespace La_Sandwicheria.Modelo.Dominio
{
    public class Comprobante
    {
        public int Id { get; set; }
        

        public int NroComprobante { get; set; }
        public TiposComprobantes TipoComprobante { get; set; }
  

        public Comprobante(){}

        public TiposComprobantes ObtenerTipoComprobante(Empresa empresa, Cliente cliente)
        {
            if(empresa.CondTributaria == CondicionTributaria.ResponsableInscripto && 
                cliente.CondTributaria == CondicionTributaria.ResponsableInscripto)
            {
                return TiposComprobantes.Factura_A;
            }
            else if(empresa.CondTributaria == CondicionTributaria.ResponsableInscripto)
            {
                return TiposComprobantes.Factura_B;
            }
            else
            {
                return TiposComprobantes.Factura_C;
            }
        }
    }
}
