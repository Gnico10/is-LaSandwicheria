using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Modelo.Dominio
{
    public class LineaDeVenta
    {
        public int Id { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }

        public double SubTotal { get; set; }

        public LineaDeVenta(int cantidad = 1) { Cantidad = cantidad; }

        public LineaDeVenta(Producto producto, int cantidad = 1)
        {
            Producto = producto;
            Cantidad = cantidad;

            ActualizarSubTotal();
        }

        public void ActualizarSubTotal()
        {
            var valor = Producto.Precio;

            foreach (var agregado in Producto.Agregados)
            {
                valor += agregado.Precio;
            }

            valor *= Cantidad;

            SubTotal = valor;
        }

        public void AgregarAgregadoProducto(Producto agregado)
        {
            Producto.AgregarAgregado(agregado);
            ActualizarSubTotal();
        }
    }
}
