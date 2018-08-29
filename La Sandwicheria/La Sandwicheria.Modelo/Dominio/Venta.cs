using La_Sandwicheria.Modelo.Configuraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Modelo.Dominio
{
    public class Venta
    {
        public int Id { get; set; }
        public Cajero CajeroDeVenta { get; set; }
        public DateTime FechaDeCreación { get; set; }
        public List<LineaDeVenta> LineasDeVenta = new List<LineaDeVenta>();
        public Comprobante Comprobante { get; set; }

        //Alto acoplamiento (AlgoNoEstaBien.jpg)

        public Cliente Cliente { get; set; }
        public PuntoDeVenta PtoDeVenta { get; set; }
        public Empresa Empresa { get; set; }
        public string CAE { get; set; }

        public TiposConceptos TipoConcepto { get; set; }
        public TiposIVA TipoImpuestoIVA { get; set; }
        public TiposTributos TipoTributo { get; set; }

        public double Total { get; set; }


        public Venta(Cajero cajeroVenta) {
            CajeroDeVenta = cajeroVenta;
            FechaDeCreación = DateTime.Now;
        }
        
        public void ActualizarTotalVenta()
        {
            var sumSubTotales = 0.0;

            foreach (var lineaVenta in LineasDeVenta)
            {
                sumSubTotales += lineaVenta.SubTotal;
            }

            Total = sumSubTotales;
        }

        public void AgregarLineaDeVenta(LineaDeVenta lineaDeVenta)
        {
            LineasDeVenta.Add(lineaDeVenta);
            ActualizarTotalVenta();
        }

        public void QuitarLineaDeVenta(LineaDeVenta lineaDeVenta)
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

        public LineaDeVenta CrearLineaDeVenta()
        {
            return new LineaDeVenta();
        }
    }
}
