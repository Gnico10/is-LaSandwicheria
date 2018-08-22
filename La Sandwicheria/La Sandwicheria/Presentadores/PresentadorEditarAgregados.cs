using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using La_Sandwicheria.Modelo.Dominio;
using La_Sandwicheria.Vistas;
using La_Sandwicheria.Interfaces;
using La_Sandwicheria.Datos.Base_de_Datos;

namespace La_Sandwicheria.Presentadores
{
    public class PresentadorEditarAgregados
    {
        private readonly IEditarAgregados _vista;
        private Producto _productoSeleccionado;

        public PresentadorEditarAgregados(Producto productoSelec, IEditarAgregados vistaEditarAgregados)
        {
            _productoSeleccionado = productoSelec;
            _vista = vistaEditarAgregados;

            CargarAgregadosDelProducto();
            CargarAgregados();
        }

        public void CargarAgregadosDelProducto()
        {
            _vista.CargarAgregadosProducto(_productoSeleccionado.Agregados);
        }

        public void CargarAgregados()
        {
            var RubroAgreg = DBAlmacen.Rubros.Find(rubro => rubro.Descripcion == "Agregados");
            _vista.ListarAgregados(RubroAgreg.ListaProductos);

        }

        internal void QuitarAgregado(Producto producto)
        {
            _productoSeleccionado.RemoverAgregado(producto);
            _vista.CargarAgregadosProducto(_productoSeleccionado.Agregados);
        }

        internal void AgregarAgregado(Producto producto)
        {
            _productoSeleccionado.AgregarAgregado(producto);
            _vista.CargarAgregadosProducto(_productoSeleccionado.Agregados);
        }
    }
}
