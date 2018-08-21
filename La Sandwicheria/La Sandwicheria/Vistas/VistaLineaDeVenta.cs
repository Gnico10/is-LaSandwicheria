using La_Sandwicheria.Modelo.Dominio;
using La_Sandwicheria.Presentadores;
using La_Sandwicheria.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_Sandwicheria.Vistas
{
    public partial class VistaLineaDeVenta : Form, ILineaDeVenta
    {
        private readonly PresentadorLineaDeVenta _presentador;

        public VistaLineaDeVenta(Venta ventaAct)
        {
            InitializeComponent();
            _presentador = new PresentadorLineaDeVenta(ventaAct,this);  
        }

        public void CargarProductos(List<Producto> Productos)
        {
            bindingSourceProducto.DataSource = Productos;
        }

        public void CargarRubros(List<Rubro> Rubros)
        {
            bindingSourcerRubro.DataSource = Rubros;
        }
        public void ColocarLineaDeVenta(LineaDeVenta LineaDeVenta)
        {
            bindingSourceLineaDeVenta.DataSource = LineaDeVenta;
        }

        private void cbxRubro_SelectedChangeComn(object sender, EventArgs e)
        {
            var RubroSelecionado = bindingSourcerRubro.Current as Rubro;
            _presentador.CargarProductos(RubroSelecionado);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnElegirProducto_Click(object sender, EventArgs e)
        {
            var ProductoSeleccionado = bindingSourceProducto.Current as Producto;
            if(ProductoSeleccionado != null)
            { 
                _presentador.ColocarProductoSeleccionado(ProductoSeleccionado);
                btnEditarAgregados.Enabled = true;
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            _presentador.ActualizarSubTotal(txtCantidad.Text);
        }

        private void btnEditarAgregados_Click(object sender, EventArgs e)
        {
            var VistaEditarAgregados = new VistaEditarAgregados(bindingSourceProducto.Current as Producto);
            VistaEditarAgregados.ShowDialog();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            _presentador.TerminarLineaDeVenta();
            Close();
        }
    }
}
