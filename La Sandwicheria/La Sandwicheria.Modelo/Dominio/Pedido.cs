using La_Sandwicheria.Modelo.Configuraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Modelo.Dominio
{
    public class Pedido
    {
        public int Id { get; set; }
        public Cajero CajeroDeVenta { get; set; }
        public DateTime FechaDeCreación { get; set; }
        public List<LineaDePedido> LineasDeVenta = new List<LineaDePedido>();
        public Comprobante Comprobante { get; set; }

        //Alto acoplamiento

        public Cliente Cliente { get; set; }
        public PuntoDeVenta PtoDeVenta { get; set; }
        public Empresa Empresa { get; set; }
        public string CAE { get; set; }

        public TiposConceptos TipoConcepto { get; set; }
        public TiposIVA TipoImpuestoIVA { get; set; }
        public TiposTributos TipoTributo { get; set; }

        public double Total { get; set; }


        public Pedido(Cajero cajeroVenta) {
            CajeroDeVenta = cajeroVenta;
            FechaDeCreación = DateTime.Now;
        }
        public void AgregarLineaDeVenta(LineaDePedido lineaDeVenta)
        {
            LineasDeVenta.Add(lineaDeVenta);
            ActualizarTotalVenta();
        }

        public void QuitarLineaDeVenta(LineaDePedido lineaDeVenta)
        {
            LineasDeVenta.Remove(lineaDeVenta);
            ActualizarTotalVenta();
        }

        public void RestarExistencia()
        {
            foreach (var Linea in LineasDeVenta)
            {
                Linea.RestarExistencia();
            }
        }

        public Comprobante GenerarComprobante()
        {
            var comprobante = new Comprobante();
            return comprobante;
        }

        public LineaDePedido CrearLineaDeVenta()
        {
            return new LineaDePedido();
        }

        private void ActualizarTotalVenta()
        {
            var sumSubTotales = 0.0;

            foreach (var lineaVenta in LineasDeVenta)
            {
                sumSubTotales += lineaVenta.SubTotal;
            }

            Total = sumSubTotales;
        }

    }
}
