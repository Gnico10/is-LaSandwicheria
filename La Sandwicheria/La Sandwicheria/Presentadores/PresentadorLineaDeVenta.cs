using La_Sandwicheria.Datos.Almacen;
using La_Sandwicheria.Interfaces;
using La_Sandwicheria.Modelo.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Presentadores
{
    public class PresentadorLineaDeVenta
    {
        private readonly ILineaDeVenta _vista;
        public Venta VentaAct { get; set;}
        public LineaDeVenta LineaActual { get; set; }

        public PresentadorLineaDeVenta(Venta ventAct, ILineaDeVenta vista)
        {
            VentaAct = ventAct;
            LineaActual = VentaAct.CrearLineaDeVenta();
            _vista = vista;
            CargarRubrosYLineaDeVenta();
        }

        public void CargarRubrosYLineaDeVenta()
        {
            _vista.CargarRubros(Almacen.Rubros);
            _vista.ColocarLineaDeVenta(LineaActual);
        }

        public void CargarProductos(Rubro RubroSelecionado)
        {
            _vista.CargarProductos(RubroSelecionado.ListaProductos);
        }

        internal void ColocarProductoSeleccionado(Producto productoSeleccionado)
        {
            LineaActual.Producto = productoSeleccionado;
            LineaActual.ActualizarSubTotal();
        }

        internal void ActualizarSubTotal(string cantidad)
        {
            if (cantidad == null)
            {
                if (LineaActual.Producto != null)
                {
                    LineaActual.ActualizarSubTotal();
                }
            }
        }

        internal void TerminarLineaDeVenta()
        {
            VentaAct.AgregarLineaDeVenta(LineaActual);
        }
    }
}
