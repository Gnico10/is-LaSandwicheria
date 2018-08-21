using La_Sandwicheria.Capa_Transversal.Configuraciones;
using La_Sandwicheria.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Capa_Transversal.Configuraciones
{
    public class Configuraciones
    {

        /*
            URL de servicios web

            Ds.dyndns.org: http://ds.dyndns.org:9000/AuthorizationService?wsdl
            AFIP: https://wswhomo.afip.gov.ar/wsfev1/service.asmx?wsdl
        */


        //Configuración para el servicio web (ds.dyndns.org) 
        public static string CodigoDeGrupo = "4EE2865D-CA3F-4A87-BEE2-2AFD98A9F288";

        //Configuraciones para el servicio de la AFIP
        public static int PuntoDeVenta = 1;
        public static int TipoCrobante = (int)TiposComprobantes.Factura_C;
        public static int TipoDocumentovendedor = (int)TiposDocumentos.CUIL;
        public static int TipoConcepto = (int)TiposConceptos.Producto;
        public static int TipoIva = (int)TiposIVA.IVA_0;
        public static int TipoTrubuto = (int)TiposTributos.Impuestos_nacionales;


    }
}
