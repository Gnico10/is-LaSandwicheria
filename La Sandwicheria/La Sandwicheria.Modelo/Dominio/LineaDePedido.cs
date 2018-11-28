using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Modelo.Dominio
{
    public class LineaDePedido
    {
        public int Id { get; set; }
        public Producto Producto { get; set; }
        public string DescripcionProducto => Producto.Descripcion;
        public int Cantidad { get; set; }

        public double SubTotal { get; set; }

        public LineaDePedido(int cantidad = 1) { Cantidad = cantidad; }

        public LineaDePedido(Producto producto, int cantidad = 1)
        {
            Producto = producto;
            Cantidad = cantidad;

            ActualizarSubTotal(cantidad);
        }

        public void ActualizarSubTotal(int cantidad = 1)
        {
            if (Cantidad != cantidad)
            {
                Cantidad = cantidad;
            }
            

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

        internal void RestarExistencia()
        {
            Producto.RestarExistencia(Cantidad);
        }
    }
}
