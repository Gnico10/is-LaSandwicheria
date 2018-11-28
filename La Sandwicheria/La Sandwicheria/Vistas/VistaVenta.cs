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
            InitializeComponent();
            _presentador = new PresentadorNuevaVenta(cajeroAct, turnoAct, this);
        }

        public void ColocarVentaAct(Pedido venta)
        {
            bindingSourceVenta.DataSource = venta;
        }

        public void CargarLineasDeVenta(List<LineaDePedido> lineasDeVenta)
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

            bindingSourceVenta.ResetBindings(false);

        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Está seguro de cancelar este proceso?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes)
                Close();
        }

        private void btnAcabarVenta_Click(object sender, EventArgs e)
        {
            if (bindingSourceLineasDeVenta.Count != 0)
            {
                var VistaTermVenta = new VistaTerminarVenta(this, _presentador.VentaActual,_presentador.TurnoAct);
                VistaTermVenta.ShowDialog();
            }

            else
            {
                MessageBox.Show("La venta no posee lineas de venta", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CerrarVenta()
        {
            Close();
        }

        private void btnRemoverLineaVenta_Click(object sender, EventArgs e)
        {
            var LineaSelec = bindingSourceLineasDeVenta.Current as LineaDePedido;
            if (LineaSelec != null)
            {
                _presentador.RemoverLineaDeVenta(LineaSelec);
            }
            else
            {
                MessageBox.Show("No tiene una linea de venta selecionada", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bindingSourceLineasDeVenta.ResetBindings(false);
            bindingSourceVenta.ResetBindings(false);
        }
    }
}
