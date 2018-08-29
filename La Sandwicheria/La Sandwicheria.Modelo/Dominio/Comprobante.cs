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

        public PuntoDeVenta PtoDeVenta { get; set; }
        public Empresa Empresa { get; set; }
        public Cliente Cliente { get; set; }
        public int NroComprobante { get; set; }
        public string CAE { get; set; }

        public TiposComprobantes TipoComprobante { get; set; }
        public TiposConceptos TipoConcepto { get; set; }
        public TiposIVA TipoImpuestoIVA { get; set; }
        public TiposTributos TipoTributo { get; set; }

        public double TotalAFacturar { get; set; }

        public Comprobante(double totalFactura)
        {
            TotalAFacturar = totalFactura;
        }

        public TiposComprobantes ObtenerTipoComprobante()
        {
            if(Empresa.CondTributaria == CondicionTributaria.ResponsableInscripto && 
                Cliente.CondTributaria == CondicionTributaria.ResponsableInscripto)
            {
                return TiposComprobantes.Factura_A;
            }
            else if(Empresa.CondTributaria == CondicionTributaria.ResponsableInscripto)
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
