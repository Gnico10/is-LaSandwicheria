using La_Sandwicheria.Datos.ServiceReferenceAFIP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Datos
{
    public class ServicioAFIP
    {
        //Conexión servicio web de la AFIP
        ServiceSoapClient ServiceConect { get; set; }
        FEAuthRequest AuthAutorizar { get; set; }
        FECompConsultaReq CompConsultaReq { get; set; }

        public ServicioAFIP(long cuit, string sign, string token, int ptoVta, int compTipo)
        {
            ServiceConect = new ServiceSoapClient();
            AuthAutorizar = new FEAuthRequest();
            CompConsultaReq = new FECompConsultaReq();

            CargarAuthRequest(cuit, sign, token);
            CargarCompConsultReq(ptoVta,compTipo);
        }

        private void CargarAuthRequest(long cuit, string sign, string token)
        {
            AuthAutorizar.Cuit = cuit;
            AuthAutorizar.Sign = sign;
            AuthAutorizar.Token = token;
        }

        private void CargarCompConsultReq(int ptoVta, int compTipo)
        {
            CompConsultaReq.PtoVta = ptoVta;
            CompConsultaReq.CbteTipo = compTipo;
        }


        public DummyResponse VerificarEnLinea()
        {
            return ServiceConect.FEDummy();
        }

        public FECompConsultaResponse ObtenerUltimaFacturaAutorizada()
        {
            return ServiceConect.FECompConsultar(AuthAutorizar,CompConsultaReq);
        }

        //Terminar
        public void AutorizarFactura(int ptoVta,int tipoComp, int conceptoComp, long compNro, double compTotal,
                                     long compDesde = 1, long compHasta = 1, int cantReg = 1)
        {
            var FECabR = new FECAECabRequest();

            FECabR.PtoVta = ptoVta; // Punto de venta.
            FECabR.CbteTipo = tipoComp; // Tipo Factura c.
            FECabR.CantReg = cantReg; // Cantidad de Registros.

            var FEDetR = new FECAEDetRequest ();
            FEDetR.Concepto = conceptoComp; //De producto
            FEDetR.DocNro = compNro; //Nro. De identificación del comprador
            FEDetR.CbteDesde = compDesde; //Nro. De comprobante desde
            FEDetR.CbteHasta = compHasta; //Nro. De comprobante registrado hasta
            FEDetR.ImpTotal = compTotal; // Importe total del comprobante
            FEDetR.ImpTotConc = 0; //Para comprobantes tipo C debe ser igual a cero(0).
            FEDetR.ImpNeto = 0; //Para comprobantes tipo C este campo corresponde al Importe del Sub Total (SIN IMPUESTO)
            FEDetR.ImpOpEx = 0; //Importe Externo. Para comprobantes tipo C debe ser igual a cero (0).
            FEDetR.ImpIVA = 0; //Importes Array IVa. Para comprobantes tipo C debe ser igual a cero (0).
            FEDetR.ImpTrib = 0; //Suma importes Array tributo.
            FEDetR.MonId = "PES"; //Codigo de moneda (PESO ARGENTINO).
            FEDetR.MonCotiz = 1; //Cotización de la moneda informada. Para PES, pesos argentinos la misma debe ser 1



            var FECAEreq = new FECAERequest();

            FECAEreq.FeCabReq = FECabR;
            FECAEreq.FeDetReq = new[] { FEDetR };

            ServiceConect.FECAESolicitar(AuthAutorizar,FECAEreq);
        }
    }
}
