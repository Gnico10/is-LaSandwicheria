using La_Sandwicheria.Datos;
using La_Sandwicheria.Datos.Base_de_Datos;
using La_Sandwicheria.Interfaces;
using La_Sandwicheria.Modelo.Dominio;
using La_Sandwicheria.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Presentadores
{
   

    public class PresentadorNuevaVenta
    {
        private readonly INuevaVenta _vista;
        public Cajero CajeroSesionAct { get; set; }
        public Turno TurnoAct { get; set; }
        public Venta VentaActual { get; }

        public PresentadorNuevaVenta(Cajero cajero, Turno turno,INuevaVenta vista)
        {
            CajeroSesionAct = cajero;
            TurnoAct = turno;
            VentaActual = cajero.InicarVenta();
            _vista = vista;

            ColocarVentaAct();
        }

        internal void CargarLineasDeVenta()
        {
            _vista.CargarLineasDeVenta(VentaActual.LineasDeVenta);
        }

        internal void ColocarVentaAct()
        {
            _vista.ColocarVentaAct(VentaActual);
        }

        internal void TerminarVenta()
        { 

            var comprobante = VentaActual.GenerarComprobante();

            //TODO : Mandar comprobante al sistema AFIP
            //var VicenteService = new ServiceClienteVicente();
            //    var cuit = VicenteService.Autorizacion.Cuit;
            //    var sign = VicenteService.Autorizacion.Sign;
            //    var token = VicenteService.Autorizacion.Token;

            //var ServicioAfip = new ServicioAFIP(cuit, sign, token, comprobante.PV, comprobante.TipoComprobante);

            //var VerificacionEnLinea = ServicioAfip.VerificarEnLinea();
            //    var EstadoAppServer = VerificacionEnLinea.AppServer;
            //    var EstadoAuthServer = VerificacionEnLinea.AuthServer;
            //    var EstadoDBServer = VerificacionEnLinea.DbServer;

            //var UltimaFactura = ServicioAfip.ObtenerUltimaFacturaAutorizada();
            //var NroFactura = UltimaFactura.ResultGet.DocNro + 1;

            //ServicioAfip.AutorizarFactura(comprobante.PV,comprobante.TipoComprobante,comprobante.TipoConcepto,NroFactura,comprobante.TotalAFacturar);

            //VicenteService.CerrarClient();
            //------------------------
            TurnoAct.AgregarVenta(VentaActual);
            VentaActual.RestarExistencia();

            //Guardar en DB
            DBVentas.GuardarVenta(VentaActual);
            DBComprobantes.GuardarComprobante(comprobante);
            //-------------

        }
    }
}
