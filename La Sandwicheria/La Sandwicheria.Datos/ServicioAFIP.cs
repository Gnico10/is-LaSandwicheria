using La_Sandwicheria.Datos.ar.gov.afip.wswhomo;
using La_Sandwicheria.Modelo.Dominio;
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
        Service ServiceConect { get; set; }
        FEAuthRequest AuthAutorizar { get; set; }

        public ServicioAFIP(long cuit, string sign, string token)
        {
            try
            {
                ServiceConect = new Service();
                AuthAutorizar = new FEAuthRequest();

                CargarAuthRequest(cuit, sign, token);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
          
        }

        private void CargarAuthRequest(long cuit, string sign, string token)
        {
            AuthAutorizar.Cuit = cuit;
            AuthAutorizar.Sign = sign;
            AuthAutorizar.Token = token;
        }


        public DummyResponse VerificarEnLinea()
        {
            return ServiceConect.FEDummy();
        }

        public FERecuperaLastCbteResponse ObtenerUltimaFacturaAutorizada(int ptoVenta, int cbteTipo)
        {
            return ServiceConect.FECompUltimoAutorizado(AuthAutorizar,ptoVenta, cbteTipo);
        }

        //Terminar
        public FECAEResponse AutorizarFactura(Venta ventaFactura)
        {
            var FECabeceraReq = new FECAECabRequest();

            FECabeceraReq.CantReg = 1;// Cantidad de Registros.
            FECabeceraReq.CbteTipo = (int)ventaFactura.Comprobante.TipoComprobante; //tipo de factura
            FECabeceraReq.PtoVta = ventaFactura.PtoDeVenta.NroPuntoDeVenta; // Numero del Punto de venta.

            var FEDetalleReq = new FECAEDetRequest ();

            FEDetalleReq.DocTipo = (int)ventaFactura.Cliente.DocTipo; //Tipo de Identificación del comprado.
            FEDetalleReq.DocNro = ventaFactura.Cliente.Cuil; //Nro. De identificación del comprador
            FEDetalleReq.MonId = ServiceConect.FEParamGetTiposMonedas(AuthAutorizar).ResultGet[0].Id;//Codigo Moneda (PES)
            FEDetalleReq.MonCotiz = 1;//Cotización de la moneda informada. Para PES, pesos argentinos la misma debe ser 1
            FEDetalleReq.CbteDesde = ventaFactura.Comprobante.NroComprobante + 1;//Nro. De comprobante desde
            FEDetalleReq.CbteHasta = ventaFactura.Comprobante.NroComprobante + 1;//Nro. De comprobante registrado hasta
            FEDetalleReq.Concepto = (int)ventaFactura.TipoConcepto;//Concepto (De producto)
            FEDetalleReq.ImpTotal = ventaFactura.Total;// Importe total del comprobante
            FEDetalleReq.ImpNeto = ventaFactura.Total;//Para comprobantes tipo C este campo corresponde al Importe del Sub Total (SIN IMPUESTO)
            FEDetalleReq.ImpTotConc = 0; //Para comprobantes tipo C debe ser igual a cero(0). 
            FEDetalleReq.ImpOpEx = 0; //Importe Externo. Para comprobantes tipo C debe ser igual a cero (0).
            FEDetalleReq.ImpIVA = 0; //Importes Array IVa. Para comprobantes tipo C debe ser igual a cero (0).
            FEDetalleReq.ImpTrib = 0; //Suma importes Array tributo.

            var FECAEreq = new FECAERequest();

            FECAEreq.FeCabReq = FECabeceraReq;
            FECAEreq.FeDetReq = new FECAEDetRequest[] { FEDetalleReq };

            return ServiceConect.FECAESolicitar(AuthAutorizar,FECAEreq);
        }
    }
}
