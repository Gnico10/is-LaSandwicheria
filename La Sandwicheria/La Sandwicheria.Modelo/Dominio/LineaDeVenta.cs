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

        public LineaDeVenta(Producto producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;

            SubTotal = ActualizarSubTotal();
        }

        public double ActualizarSubTotal()
        {
            var valor = Producto.Precio * Cantidad;

            foreach (var agregado in Producto.Agregados)
            {
                valor += agregado.Precio;
            }

            return valor;
        }
    }
}
