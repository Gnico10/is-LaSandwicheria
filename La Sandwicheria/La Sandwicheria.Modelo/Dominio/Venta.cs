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
        public double Total { get; set; }


        public Venta(Cajero cajeroVenta) {
            CajeroDeVenta = cajeroVenta;
            FechaDeCreación = DateTime.Now;
        }
        
        public void ActualizarTotalVenta()
        {
            foreach(var venta in LineasDeVenta)
            {
                Total += venta.SubTotal;
            }
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
            var comprobante = new Comprobante(Total);
            Comprobante = comprobante;
            return comprobante;
        }

        public LineaDeVenta CrearLineaDeVenta()
        {
            return new LineaDeVenta();
        }
    }
}
