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

        public VistaVenta(Cajero cajeroAct)
        {
            _presentador = new PresentadorNuevaVenta(cajeroAct,this);
            InitializeComponent();
        }

        public void CargarLineasDeVenta(List<LineaDeVenta> lineasDeVenta)
        {
            throw new NotImplementedException();
        }

        public void Inicar(LineaDeVenta lineaDeVenta)
        {
            throw new NotImplementedException();
        }
    }
}
