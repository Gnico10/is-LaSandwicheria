using La_Sandwicheria.Interfaces;
using La_Sandwicheria.Modelo.Dominio;
using La_Sandwicheria.Presentadores;
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
    public partial class VistaEditarAgregados : Form, IEditarAgregados
    {
        private readonly PresentadorEditarAgregados _presentador;

        public VistaEditarAgregados(Producto ProductoSeleccionado)
        {
            InitializeComponent();
            _presentador = new PresentadorEditarAgregados(ProductoSeleccionado,this);
        }

        public void CargarAgregadosProducto(List<Producto> Productos)
        {
            bindingSourceProdAgregados.DataSource = Productos;
            bindingSourceProdAgregados.ResetBindings(false);
        }

        public void ListarAgregados(List<Producto> Productos)
        {
            bindingSourceAgregados.DataSource = Productos;
            bindingSourceProdAgregados.ResetBindings(false);
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            _presentador.QuitarAgregado(bindingSourceProdAgregados.Current as Producto);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            _presentador.AgregarAgregado(bindingSourceAgregados.Current as Producto);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
