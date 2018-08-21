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
    public partial class Menu : Form
    {
        private readonly PresentadorMenu _presentador;

        public Menu(Cajero cajero)
        {
            _presentador = new PresentadorMenu(cajero);
            InitializeComponent();
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            var VentanaVenta = new VistaVenta(_presentador.CajeroSesionAct, _presentador.TurnoAct);
            VentanaVenta.ShowDialog();
        }

        private void btnCerrarTurno_Click(object sender, EventArgs e)
        {
            DialogResult Opcion = MessageBox.Show($"¿Desea cerrar el Turno actual? \n\n Turno de: {_presentador.CajeroSesionAct.NombreYApe}\n Inicio del turno: {_presentador.TurnoAct.FechaYHora}\n\n Recaudación del turno: $ {_presentador.TurnoAct.Rendicion}","Cerrar Turno",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (Opcion == DialogResult.OK)
            {
                _presentador.CerrarTurno();
                Application.Exit();
                //Close();
            }
        }
    }
}
