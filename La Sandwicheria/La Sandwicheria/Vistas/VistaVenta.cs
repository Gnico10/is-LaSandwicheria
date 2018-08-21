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
using La_Sandwicheria.Modelo.Dominio;
using La_Sandwicheria.Presentadores;

namespace La_Sandwicheria.Vistas
{
    public partial class VistaVenta : Form , INuevaVenta
    {
        private readonly PresentadorNuevaVenta _presentador;

        public VistaVenta(Cajero cajeroAct, Turno turnoAct)
        {
            _presentador = new PresentadorNuevaVenta(cajeroAct, turnoAct, this);
            InitializeComponent();
        }

        public void CargarLineasDeVenta(List<LineaDeVenta> lineasDeVenta)
        {
            bindingSourceLineasDeVenta.DataSource = lineasDeVenta;
            bindingSourceLineasDeVenta.ResetBindings(false);
        }

        private void btnNuevaLineaVenta_Click(object sender, EventArgs e)
        {
            var VistaNuevaLineaVenta = new VistaLineaDeVenta(_presentador.VentaActual);
            VistaNuevaLineaVenta.ShowDialog();

            //Cargar nueva linea de venta
            _presentador.CargarLineasDeVenta();

        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
