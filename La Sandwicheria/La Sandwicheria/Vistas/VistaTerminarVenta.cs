using La_Sandwicheria.Interfaces;
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
using La_Sandwicheria.Modelo.Dominio;

namespace La_Sandwicheria.Vistas
{
    public partial class VistaTerminarVenta : Form, ITerminarVenta
    {
        private readonly PresentadorTerminarVenta _presentador;
        private readonly INuevaVenta _vistaVenta;

        public VistaTerminarVenta(INuevaVenta vistaVenta, Venta venta, Turno turno)
        {
            _vistaVenta = vistaVenta;

            InitializeComponent();

            _presentador = new PresentadorTerminarVenta(this, venta, turno);

            cbxCondTributariaCliente.DataSource = Enum.GetValues(typeof(CondicionTributaria));
            cbxCondTributariaCliente.SelectedItem = CondicionTributaria.ConsumidorFinal;
            cbxCondTributariaEmpresa.DataSource = Enum.GetValues(typeof(CondicionTributaria));
            cbxCondTributariaEmpresa.SelectedItem = CondicionTributaria.Monotributista;

        }

        public void CargarCliente(Cliente cliente)
        {
            bindingSourceCliente.DataSource = cliente;
        }

        public void CargarEmpresa(Empresa empresa)
        {
            bindingSourceEmpresa.DataSource = empresa;
        }

        public void CargarPtosDeVenta(List<PuntoDeVenta> ptosDeVenta)
        {
            bindingSourcePtoDeVenta.DataSource = ptosDeVenta;
        }

        private void btnAcabarVenta_Click(object sender, EventArgs e)
        {
            var PtoDeVentaAct = cbxPuntoDeVenta.SelectedItem as PuntoDeVenta;
            var isFinalizado = _presentador.AcabarVenta(PtoDeVentaAct);

            if (isFinalizado == true) {
                MessageBox.Show("La nueva venta fue creada\n Comprobante emitido", "Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _vistaVenta.CerrarVenta();
                Close();
            }
            else
            {
                MessageBox.Show("NO SE PUDO ESTABLECER LA CONEXIÓN\n Compruebe su conexión a internet y reintente", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Está seguro de cancelar este proceso?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(opcion == DialogResult.Yes)
                Close();
        }
    }
}
