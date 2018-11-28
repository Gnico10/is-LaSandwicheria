using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using La_Sandwicheria.Modelo.Dominio;
using La_Sandwicheria.Vistas;
using La_Sandwicheria.Interfaces;
using La_Sandwicheria.Datos.Base_de_Datos;
using La_Sandwicheria.Datos;
using La_Sandwicheria.Modelo.Configuraciones;

namespace La_Sandwicheria.Presentadores
{
    class PresentadorTerminarVenta
    {
        private readonly ITerminarVenta _vistaTerminarVenta;
        private readonly Pedido _ventaAct;
        private readonly Turno _turnoAct;
        
        public Cliente Cliente { get; set; }

        public PresentadorTerminarVenta(ITerminarVenta vistaTerminarVenta, Pedido comprobanteActual, Turno turnoActual)
        {
            _vistaTerminarVenta = vistaTerminarVenta;
            _ventaAct = comprobanteActual;
            _turnoAct = turnoActual;

            //Intanciación de PtosDeVenta
            DBPtosVentas.CargarPtosDeVenta();
            //-----------------------

            Empresa.Intancia().Nombre = "LA SANDWICHERÍA";
            Empresa.Intancia().PtosDeVenta = DBPtosVentas.PtosDeVenta;
            //-----------------------

            Cliente = new Cliente("Cliente",00000000000);

            CargarPuntosDeVenta();
            CargarEmpresa();
            CargarCliente();

        }

        public void CargarPuntosDeVenta()
        {
            _vistaTerminarVenta.CargarPtosDeVenta(Empresa.Intancia().PtosDeVenta);
        }

        public void CargarEmpresa()
        {
            _vistaTerminarVenta.CargarEmpresa(Empresa.Intancia());
        }

        public void CargarCliente()
        {
            _vistaTerminarVenta.CargarCliente(Cliente);
        }

        internal bool AcabarVenta(PuntoDeVenta ptoDeVenta)
        {
            _ventaAct.Empresa = Empresa.Intancia();
            _ventaAct.Cliente = Cliente;
            _ventaAct.PtoDeVenta = ptoDeVenta;
            _ventaAct.Comprobante = _ventaAct.GenerarComprobante();

            _ventaAct.Comprobante.TipoComprobante = _ventaAct.Comprobante.ObtenerTipoComprobante(_ventaAct.Empresa,_ventaAct.Cliente);
            _ventaAct.TipoConcepto = TiposConceptos.Producto;
            _ventaAct.TipoImpuestoIVA = TiposIVA.IVA_0;
            _ventaAct.TipoTributo = TiposTributos.Otro;

            //Sistema Autorización

                var VicenteService = new ServiceClienteVicente();
            try
            {
                var cuit = VicenteService.Autorizacion.Cuit;
                var sign = VicenteService.Autorizacion.Sign;
                var token = VicenteService.Autorizacion.Token;

                Empresa.Intancia().TipoDocumento = TiposDocumentos.CUIT;
                Empresa.Intancia().NroDocumento = cuit;
                
                Console.Write($"{cuit}, {sign}, {token}");

                //Sistema AFIP
                var ServicioAFIP = new ServicioAFIP(Empresa.Intancia().NroDocumento, sign, token);

                var VerificacionEnLinea = ServicioAFIP.VerificarEnLinea();

                var EstadoAppServer = VerificacionEnLinea.AppServer;
                var EstadoDBServer = VerificacionEnLinea.DbServer;

                Console.Write($"{EstadoAppServer}, {EstadoDBServer}");

                if (EstadoAppServer == "OK" && EstadoDBServer == "OK")
                {
                    var UltimoCompAutorizado = ServicioAFIP.ObtenerUltimaFacturaAutorizada(_ventaAct.PtoDeVenta.NroPuntoDeVenta, (int)_ventaAct.Comprobante.TipoComprobante);
                    var NroUltimoAutorizado = UltimoCompAutorizado.CbteNro;

                    _ventaAct.Comprobante.NroComprobante = NroUltimoAutorizado + 1;

                    var FECAE = ServicioAFIP.AutorizarFactura(_ventaAct);
                    _ventaAct.CAE = FECAE.FeDetResp[0].CAE;
                }

            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

                VicenteService.CerrarClient();
            //-----------------------

            _turnoAct.AgregarVenta(_ventaAct);
            _ventaAct.RestarExistencia();

            //Guardar en DB
            DBVentas.GuardarVenta(_ventaAct);
            DBComprobantes.GuardarComprobante(_ventaAct.Comprobante);
            //-------------

            return true;

        }
    }
}
