using La_Sandwicheria.Capa_Transversal.Configuraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Modelo.Dominio
{
    public class Comprobante
    {
        public int Id { get; set; }

        public int PV = Configuraciones.PuntoDeVenta;
        public int TipoComprobante => Configuraciones.TipoCrobante;
        public int TipoConcepto => Configuraciones.TipoConcepto;
        public int TiposDocumentos => Configuraciones.TipoDocumentoVendedor;
        public int TipoImpuestoIVA => Configuraciones.TipoIva;
        public int TipoTributo => Configuraciones.TipoTributo;

        public double TotalAFacturar { get; set; }

        public Comprobante(double totalFactura)
        {
            TotalAFacturar = totalFactura;
        }
    }
}
